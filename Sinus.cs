using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miw_genetic_alg
{
    public static class Sinus
    {
        public static int bitsPerParameter = 4;
        public static int parameters = 3;
        public static double minFitness = 0.0;
        public static double maxFitness = 3.0;
        public static int populationSize = 13;
        public static int tournamentSize = 3;
        public static string sampleDataFilePath = "./sinusik.txt";

        public static Action<string> Output = (string _) => { };

        public static int maxIterations = 100;

        public static Dictionary<byte[], double> decodeDictionary = Common.CreateDecodeTable(minFitness, maxFitness, bitsPerParameter);
        public static (double, double)[]? sampleData = null;

        private static long TournamentSelectEvaluator(long[] tournament, double[] fitness) => tournament.MinBy(fitness.GetValue);

        private static void ReadSampleData(string path)
        {
            var data = File.ReadAllLines(path);
            sampleData = data.Select((string line) =>
            {
                return line.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    switch { var a => (double.Parse(a[0], CultureInfo.InvariantCulture), double.Parse(a[1], CultureInfo.InvariantCulture)) };
            }).ToArray();
        }

        static double ModelFunction(double x, double pa, double pb, double pc)
        {
            return pa * Math.Sin(pb * x + pc);
        }

        static double FitnessFuntion(double pa, double pb, double pc, (double, double)[] sampleData)
        {
            var error = 0.0;
            foreach ((double x, double r) in sampleData)
            {
                var tangent = ModelFunction(x, pa, pb, pc);
                error += Math.Pow(r - tangent, 2.0);
            }
            return error;
        }

        static double[] EvaluateFitness(byte[][] population)
        {
            double[] fitness = [];
            if (sampleData == null)
            {
                ReadSampleData(sampleDataFilePath);
            }

            foreach (byte[] entity in population)
            {
                var param1 = Common.GetParameter(entity, 0, bitsPerParameter);
                var param2 = Common.GetParameter(entity, 1, bitsPerParameter);
                var param3 = Common.GetParameter(entity, 2, bitsPerParameter);
                var pa = decodeDictionary[param1];
                var pb = decodeDictionary[param2];
                var pc = decodeDictionary[param3];

                fitness = [.. fitness, FitnessFuntion(pa, pb, pc, sampleData!)];
            }

            return fitness;
        }
        public static byte[] BestEntity(byte[][] population, double[] fitness)
        {
            int bestIdx = 0;
            for (int i = 1; i < population.Length; ++i)
            {
                if (fitness[bestIdx] > fitness[i]) bestIdx = i;
            }

            return (byte[])population[bestIdx].Clone();
        }

        public static (double, double, double, double) GeneticAlgorithm()
        {
            var population = Common.CreatePopulation(populationSize, parameters, bitsPerParameter);
            var fitness = EvaluateFitness(population);

            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                var bestFitness = fitness.Min();
                var avgFitness = fitness.Average();

                Output($"Iteracja {iteration}: Najlepszy błąd = {bestFitness:F6}, Średni błąd = {avgFitness:F6}");

                byte[][] newPopulation = [];

                for (int j = 0; j < 2; j++)
                {
                    var parent1 = Common.TournamentSelect(population, fitness, tournamentSize, TournamentSelectEvaluator);
                    var parent2 = Common.TournamentSelect(population, fitness, tournamentSize, TournamentSelectEvaluator);

                    var (child1, child2) = Common.Crossover(parent1, parent2);
                    newPopulation = [.. newPopulation, child1, child2];
                }
                for (int j = 0; j < 4; j++)
                {
                    var entity = Common.TournamentSelect(population, fitness, tournamentSize, TournamentSelectEvaluator);
                    Common.MutateRandom(ref entity, parameters, bitsPerParameter);
                    newPopulation = [.. newPopulation, entity];
                }
                for (int j = 0; j < 2; j++)
                {
                    var parent1 = Common.TournamentSelect(population, fitness, tournamentSize, TournamentSelectEvaluator);
                    var parent2 = Common.TournamentSelect(population, fitness, tournamentSize, TournamentSelectEvaluator);

                    var (child1, child2) = Common.Crossover(parent1, parent2);
                    Common.MutateRandom(ref child1, parameters, bitsPerParameter);
                    Common.MutateRandom(ref child2, parameters, bitsPerParameter);
                    newPopulation = [.. newPopulation, child1, child2];
                }

                var bestEntity = BestEntity(population, fitness);
                newPopulation = [.. newPopulation, bestEntity];

                population = newPopulation;
                fitness = EvaluateFitness(population);
            }

            {
                int bestIdx = 0;
                for (int i = 0; i < populationSize; ++i)
                {
                    if (fitness[bestIdx] > fitness[i]) bestIdx = i;
                }
                var bestEntity = population[bestIdx];
                var pa = decodeDictionary[Common.GetParameter(bestEntity, 0, bitsPerParameter)];
                var pb = decodeDictionary[Common.GetParameter(bestEntity, 1, bitsPerParameter)];
                var pc = decodeDictionary[Common.GetParameter(bestEntity, 2, bitsPerParameter)];
                var bestFitness = fitness[bestIdx];

                Output($"Wynik końcowy:\n" +
                    $"\tpa = {pa:F4}, pb = {pb:F4}\n, pc = {pc:F4}" +
                    $"\tWartość funkcji przystosowania: {bestFitness:F6}");

                return (pa, pb, pc, bestFitness);
            }
        }
    }
}
