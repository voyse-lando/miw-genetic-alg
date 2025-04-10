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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label4 = new Label();
            sinIterNum = new NumericUpDown();
            label5 = new Label();
            sinBppNum = new NumericUpDown();
            label6 = new Label();
            sinPopNum = new NumericUpDown();
            sinAuto = new Button();
            sinStep = new Button();
            sinReset = new Button();
            output2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)populationNumeric).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iterationNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bppNumeric).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sinIterNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sinBppNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sinPopNum).BeginInit();
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
            groupBox1.Location = new Point(0, 3);
            groupBox1.Margin = new Padding(20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(702, 434);
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
            panel1.Size = new Size(690, 319);
            panel1.TabIndex = 7;
            // 
            // autoButton
            // 
            autoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            autoButton.Location = new Point(243, 293);
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
            stepButton.Location = new Point(84, 293);
            stepButton.Name = "stepButton";
            stepButton.Size = new Size(153, 23);
            stepButton.TabIndex = 2;
            stepButton.Text = "Krok";
            stepButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            resetButton.Location = new Point(3, 293);
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
            output1.Size = new Size(684, 284);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(710, 465);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(702, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Magiczny dywanik";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(sinIterNum);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(sinBppNum);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(sinPopNum);
            tabPage2.Controls.Add(sinAuto);
            tabPage2.Controls.Add(sinStep);
            tabPage2.Controls.Add(sinReset);
            tabPage2.Controls.Add(output2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(702, 437);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sinusik";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 97);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 16;
            label4.Text = "Iteracje";
            // 
            // sinIterNum
            // 
            sinIterNum.Location = new Point(122, 95);
            sinIterNum.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            sinIterNum.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            sinIterNum.Name = "sinIterNum";
            sinIterNum.Size = new Size(120, 23);
            sinIterNum.TabIndex = 15;
            sinIterNum.Value = new decimal(new int[] { 100, 0, 0, 0 });
            sinIterNum.ValueChanged += sinIterNum_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 68);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 14;
            label5.Text = "Bity na chromosom";
            // 
            // sinBppNum
            // 
            sinBppNum.Location = new Point(122, 66);
            sinBppNum.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            sinBppNum.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            sinBppNum.Name = "sinBppNum";
            sinBppNum.Size = new Size(120, 23);
            sinBppNum.TabIndex = 12;
            sinBppNum.Value = new decimal(new int[] { 4, 0, 0, 0 });
            sinBppNum.ValueChanged += sinBppNum_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 39);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 10;
            label6.Text = "Populacja";
            // 
            // sinPopNum
            // 
            sinPopNum.Location = new Point(122, 37);
            sinPopNum.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            sinPopNum.Minimum = new decimal(new int[] { 13, 0, 0, 0 });
            sinPopNum.Name = "sinPopNum";
            sinPopNum.Size = new Size(120, 23);
            sinPopNum.TabIndex = 8;
            sinPopNum.Value = new decimal(new int[] { 13, 0, 0, 0 });
            sinPopNum.ValueChanged += sinPopNum_ValueChanged;
            // 
            // sinAuto
            // 
            sinAuto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sinAuto.Location = new Point(248, 414);
            sinAuto.Name = "sinAuto";
            sinAuto.Size = new Size(136, 23);
            sinAuto.TabIndex = 13;
            sinAuto.Text = "Auto";
            sinAuto.UseVisualStyleBackColor = true;
            sinAuto.Click += sinAuto_Click;
            // 
            // sinStep
            // 
            sinStep.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sinStep.Location = new Point(89, 414);
            sinStep.Name = "sinStep";
            sinStep.Size = new Size(153, 23);
            sinStep.TabIndex = 11;
            sinStep.Text = "Krok";
            sinStep.UseVisualStyleBackColor = true;
            // 
            // sinReset
            // 
            sinReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sinReset.Location = new Point(8, 414);
            sinReset.Name = "sinReset";
            sinReset.Size = new Size(75, 23);
            sinReset.TabIndex = 9;
            sinReset.Text = "Reset";
            sinReset.UseVisualStyleBackColor = true;
            // 
            // output2
            // 
            output2.AcceptsReturn = true;
            output2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            output2.Location = new Point(8, 124);
            output2.Multiline = true;
            output2.Name = "output2";
            output2.ReadOnly = true;
            output2.ScrollBars = ScrollBars.Vertical;
            output2.Size = new Size(684, 284);
            output2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 465);
            Controls.Add(tabControl1);
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
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sinIterNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)sinBppNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)sinPopNum).EndInit();
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
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private NumericUpDown sinIterNum;
        private Label label5;
        private NumericUpDown sinBppNum;
        private Label label6;
        private NumericUpDown sinPopNum;
        private Button sinAuto;
        private Button sinStep;
        private Button sinReset;
        private TextBox output2;
    }
}
