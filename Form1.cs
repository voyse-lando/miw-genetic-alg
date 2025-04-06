namespace miw_genetic_alg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populationNumeric.Value = MutationCarpet.populationSize;
            bppNumeric.Value = MutationCarpet.bitsPerParameter;
            iterationNumeric.Value = MutationCarpet.maxIterations;

            MutationCarpet.Output = (string data) =>
            {
                output1.AppendText(data);
                output1.AppendText(Environment.NewLine);
            };

            output1.Clear();
        }

        private void populationNumeric_ValueChanged(object sender, EventArgs e)
        {
            MutationCarpet.populationSize = (int)populationNumeric.Value;
        }

        private void bppNumeric_ValueChanged(object sender, EventArgs e)
        {
            MutationCarpet.bitsPerParameter = (int)bppNumeric.Value;
        }

        private void iterationNumeric_ValueChanged(object sender, EventArgs e)
        {
            MutationCarpet.maxIterations = (int)iterationNumeric.Value;
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            MutationCarpet.decodeDictionary = Common.CreateDecodeTable(MutationCarpet.minFitness, MutationCarpet.maxFitness, MutationCarpet.bitsPerParameter);
            MutationCarpet.GeneticAlgorithm();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            output1.Clear();
        }
    }
}
