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
            sinPopNum.Value = Sinus.populationSize;
            sinBppNum.Value = Sinus.bitsPerParameter;
            sinIterNum.Value = Sinus.maxIterations;

            MutationCarpet.Output = (string data) =>
            {
                output1.AppendText(data);
                output1.AppendText(Environment.NewLine);
            };
            Sinus.Output = (string data) =>
            {
                output2.AppendText(data);
                output2.AppendText(Environment.NewLine);
            };

            output1.Clear();
            output2.Clear();
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

        private void sinPopNum_ValueChanged(object sender, EventArgs e)
        {
            Sinus.populationSize = (int)sinPopNum.Value;
        }

        private void sinBppNum_ValueChanged(object sender, EventArgs e)
        {
            Sinus.bitsPerParameter = (int)sinBppNum.Value;
        }

        private void sinIterNum_ValueChanged(object sender, EventArgs e)
        {
            Sinus.maxIterations = (int)sinIterNum.Value;
        }

        private void sinAuto_Click(object sender, EventArgs e)
        {
            Sinus.decodeDictionary = Common.CreateDecodeTable(Sinus.minFitness, Sinus.maxFitness, Sinus.bitsPerParameter);
            Sinus.GeneticAlgorithm();
        }
    }
}
