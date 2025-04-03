namespace miw_genetic_alg
{

    internal static class Program
    {
        static readonly Random random = new Random();

        [STAThread]
        static void Main()
        {
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Exercise1.GeneticAlgorithm();
        }

    }
}