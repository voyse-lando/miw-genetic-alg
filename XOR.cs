using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miw_genetic_alg
{
    public static class XOR
    {
        public static int bitsPerParameter = 8;
        public static int parameters = 9;
        public static double minWeight = -10.0;
        public static double maxWeight = 10.0;
        public static int populationSize = 50;
        public static int tournamentSize = 5;
        public static int maxIterations = 100;

        public static Action<string> Output = (string _) => { };

        private static Random random = new Random();
        private static Dictionary<byte[], double> decodeDictionary = Common.CreateDecodeTable(minWeight, maxWeight, bitsPerParameter);
        private static long TournamentSelectEvaluator(long[] tournament, double[] fitness) => tournament.MinBy(fitness.GetValue);

        private static readonly double[][] xorInputs = new double[][]
        {
            new double[] {0, 0},
            new double[] {0, 1},
            new double[] {1, 0},
            new double[] {1, 1}
        };
        private static readonly double[] xorOutputs = new double[] { 0, 1, 1, 0 };
        private static double Sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        private static double CalculateNetworkOutput(double[] inputs, double[] weights)
        {
            double hidden1 = Sigmoid(weights[0] * 1 + weights[1] * inputs[0] + weights[2] * inputs[1]);
            double hidden2 = Sigmoid(weights[3] * 1 + weights[4] * inputs[0] + weights[5] * inputs[1]);

            double output = Sigmoid(weights[6] * 1 + weights[7] * hidden1 + weights[8] * hidden2);
            return output;
        }

        private static double FitnessFunction(byte[] entity)
        {
            double[] weights = DecodeEntity(entity);
            double error = 0.0;

            for (int i = 0; i < xorInputs.Length; i++)
            {
                double predicted = CalculateNetworkOutput(xorInputs[i], weights);
                error += Math.Pow(xorOutputs[i] - predicted, 2);
            }

            return error;
        }

        private static double[] DecodeEntity(byte[] entity)
        {
            double[] weights = new double[parameters];
            for (int i = 0; i < parameters; i++)
            {
                var paramBits = Common.GetParameter(entity, i, bitsPerParameter);
                weights[i] = decodeDictionary[paramBits];
            }
            return weights;
        }

        private static double[] EvaluateFitness(byte[][] population)
        {
            double[] fitness = new double[populationSize];

            for (int i = 0; i < populationSize; i++)
            {
                fitness[i] = FitnessFunction(population[i]);
            }

            return fitness;
        }

        public static (double[] weights, double error) GeneticAlgorithm()
        {
            var population = Common.CreatePopulation(populationSize, parameters, bitsPerParameter);
            var fitness = EvaluateFitness(population);

            for (int iteration = 0; iteration < maxIterations; ++iteration)
            {
                byte[][] newPopulation = new byte[populationSize][];

                int bestIndex = Array.IndexOf(fitness, fitness.Max());
                newPopulation[0] = (byte[])population[bestIndex].Clone();

                for (int i = 1; i < populationSize; i += 2)
                {
                    var parent1 = Common.TournamentSelect(population, fitness, tournamentSize, TournamentSelectEvaluator);
                    var parent2 = Common.TournamentSelect(population, fitness, tournamentSize, TournamentSelectEvaluator);
                    var (child1, child2) = Common.Crossover(parent1, parent2);

                    Common.MutateRandom(ref child1, parameters, bitsPerParameter);
                    Common.MutateRandom(ref child2, parameters, bitsPerParameter);

                    if (i < populationSize - 1)
                    {
                        newPopulation[i] = child1;
                        newPopulation[i + 1] = child2;
                    }
                    else
                    {
                        newPopulation[i] = child1;
                    }
                }

                population = newPopulation;
                fitness = EvaluateFitness(newPopulation);

                double bestFitness = fitness.Min();
                double avgFitness = fitness.Average();

                Output($"Iteracja {iteration}: Najlepsza SSE = {bestFitness:F4}, Średnia SSE = {avgFitness:F4}");
            }

            int finalBestIndex = Array.IndexOf(fitness, fitness.Min());
            var bestIndividual = population[finalBestIndex];
            var bestWeights = DecodeEntity(bestIndividual);
            var bestError = fitness[finalBestIndex];
            Output("\nTestowanie najlepszego rozwiązania:");
            for (int i = 0; i < xorInputs.Length; i++)
            {
                double output = CalculateNetworkOutput(xorInputs[i], bestWeights);
                Output($"Wejście: [{xorInputs[i][0]}, {xorInputs[i][1]}], Oczekiwane: {xorOutputs[i]}, Otrzymane: {output:F2}");
            }

            return (bestWeights, bestError);
        }
    }
}
