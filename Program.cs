namespace miw_genetic_alg
{

    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //MutationCarpet.GeneticAlgorithm();
        }

    }
}