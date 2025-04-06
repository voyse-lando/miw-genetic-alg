namespace miw_genetic_alg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            populationNumeric = new NumericUpDown();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            autoButton = new Button();
            stepButton = new Button();
            resetButton = new Button();
            output1 = new TextBox();
            label3 = new Label();
            iterationNumeric = new NumericUpDown();
            label2 = new Label();
            bppNumeric = new NumericUpDown();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)populationNumeric).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iterationNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bppNumeric).BeginInit();
            SuspendLayout();
            // 
            // populationNumeric
            // 
            populationNumeric.Location = new Point(123, 22);
            populationNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            populationNumeric.Name = "populationNumeric";
            populationNumeric.Size = new Size(120, 23);
            populationNumeric.TabIndex = 1;
            populationNumeric.ValueChanged += populationNumeric_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(iterationNumeric);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(bppNumeric);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(populationNumeric);
            groupBox1.Location = new Point(29, 29);
            groupBox1.Margin = new Padding(20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 344);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Magiczny dywanik";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(autoButton);
            panel1.Controls.Add(stepButton);
            panel1.Controls.Add(resetButton);
            panel1.Controls.Add(output1);
            panel1.Location = new Point(6, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 229);
            panel1.TabIndex = 7;
            // 
            // autoButton
            // 
            autoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            autoButton.Location = new Point(243, 203);
            autoButton.Name = "autoButton";
            autoButton.Size = new Size(136, 23);
            autoButton.TabIndex = 3;
            autoButton.Text = "Auto";
            autoButton.UseVisualStyleBackColor = true;
            autoButton.Click += autoButton_Click;
            // 
            // stepButton
            // 
            stepButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            stepButton.Location = new Point(84, 203);
            stepButton.Name = "stepButton";
            stepButton.Size = new Size(153, 23);
            stepButton.TabIndex = 2;
            stepButton.Text = "Krok";
            stepButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            resetButton.Location = new Point(3, 203);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 1;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // output1
            // 
            output1.AcceptsReturn = true;
            output1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            output1.Location = new Point(3, 3);
            output1.Multiline = true;
            output1.Name = "output1";
            output1.ReadOnly = true;
            output1.ScrollBars = ScrollBars.Vertical;
            output1.Size = new Size(506, 194);
            output1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 82);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "Iteracje";
            // 
            // iterationNumeric
            // 
            iterationNumeric.Location = new Point(123, 80);
            iterationNumeric.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            iterationNumeric.Name = "iterationNumeric";
            iterationNumeric.Size = new Size(120, 23);
            iterationNumeric.TabIndex = 5;
            iterationNumeric.ValueChanged += iterationNumeric_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 4;
            label2.Text = "Bity na chromosom";
            // 
            // bppNumeric
            // 
            bppNumeric.Location = new Point(123, 51);
            bppNumeric.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            bppNumeric.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            bppNumeric.Name = "bppNumeric";
            bppNumeric.Size = new Size(120, 23);
            bppNumeric.TabIndex = 3;
            bppNumeric.Value = new decimal(new int[] { 3, 0, 0, 0 });
            bppNumeric.ValueChanged += bppNumeric_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 24);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Populacja";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 402);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Algorytm genetyczny";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)populationNumeric).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iterationNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)bppNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown populationNumeric;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private NumericUpDown bppNumeric;
        private Panel panel1;
        private Button autoButton;
        private Button stepButton;
        private Button resetButton;
        private TextBox output1;
        private Label label3;
        private NumericUpDown iterationNumeric;
    }
}
