using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miw_genetic_alg
{
    public static class MutationCarpet
    {
        public static int bitsPerParameter = 7;
        public static int parameters = 2;
        public static double minFitness = 0.0;
        public static double maxFitness = 100.0;
        public static int populationSize = 19;
        public static int tournamentSize = Math.Max(2, (int)(0.1 * populationSize));

        public static int maxIterations = 20;

        public static Dictionary<byte[], double> decodeDictionary = Common.CreateDecodeTable(minFitness, maxFitness, bitsPerParameter);

        static double FitnessFuntion(double x1, double x2)
        {
            return Math.Sin(x1 * 0.05) + Math.Sin(x2 * 0.05) + 0.4 * Math.Sin(x1 * 0.15) * Math.Sin(x2 * 0.15);
        }

        static double[] EvaluateFitness(byte[][] population)
        {
            double[] fitness = [];
            foreach (byte[] entity in population)
            {
                var param1 = Common.GetParameter(entity, 0, bitsPerParameter);
                var param2 = Common.GetParameter(entity, 1, bitsPerParameter);
                var x1 = decodeDictionary[param1];
                var x2 = decodeDictionary[param2];

                fitness = fitness.Append(FitnessFuntion(x1, x2)).ToArray();
            }

            return fitness;
        }

        public static (double, double, double) GeneticAlgorithm()
        {
            var population = Common.CreatePopulation(populationSize, parameters, bitsPerParameter);
            var fitness = EvaluateFitness(population);

            for (int iteration = 0; iteration < maxIterations; iteration++)
            {
                var bestFitness = fitness.Max();
                var avgFitness = fitness.Average();

                MessageBox.Show($"Iteracja {iteration}: Najlepsza wartość = {bestFitness:F4}, Średnia wartość = {avgFitness:F4}");

                byte[][] newPopulation = [];

                for (int j = 0; j < populationSize - 1; j++)
                {
                    var entity = Common.TournamentSelect(population, fitness, tournamentSize);
                    Common.MutateRandom(ref entity);
                    newPopulation = newPopulation.Append(entity).ToArray();
                }

                var bestEntity = Common.BestEntity(population, fitness);
                newPopulation = newPopulation.Append(bestEntity).ToArray();

                population = newPopulation;
                fitness = EvaluateFitness(population);
            }

            {
                int bestIdx = 0;
                for (int i = 0; i < populationSize; ++i)
                {
                    if (fitness[bestIdx] < fitness[i]) bestIdx = i;
                }
                var bestEntity = population[bestIdx];
                var x1 = decodeDictionary[Common.GetParameter(bestEntity, 0, bitsPerParameter)];
                var x2 = decodeDictionary[Common.GetParameter(bestEntity, 1, bitsPerParameter)];
                var bestFitness = fitness[bestIdx];

                MessageBox.Show($"Wynik końcowy:\n" +
                    $"x1 = {x1:F4}, x2 = {x2:F4}\n" +
                    $"Wartość funkcji przystosowania: {bestFitness:F4}");

                return (x1, x2, bestFitness);
            }
        }
    }
}
