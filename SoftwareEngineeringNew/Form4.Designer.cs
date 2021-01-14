namespace SoftwareEngineeringNew
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFunction = new System.Windows.Forms.ComboBox();
            this.numericUpDownV1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownV2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discrete distribution";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 33);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(521, 563);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(543, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(469, 212);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Function:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 657);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "n:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "p:";
            // 
            // comboBoxFunction
            // 
            this.comboBoxFunction.FormattingEnabled = true;
            this.comboBoxFunction.Items.AddRange(new object[] {
            "Binomial distribution",
            "The Poisson Distribution"});
            this.comboBoxFunction.Location = new System.Drawing.Point(101, 611);
            this.comboBoxFunction.Name = "comboBoxFunction";
            this.comboBoxFunction.Size = new System.Drawing.Size(428, 24);
            this.comboBoxFunction.TabIndex = 6;
            this.comboBoxFunction.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunction_SelectedIndexChanged);
            this.comboBoxFunction.Click += new System.EventHandler(this.comboBoxFunction_Click);
            // 
            // numericUpDownV1
            // 
            this.numericUpDownV1.Location = new System.Drawing.Point(101, 657);
            this.numericUpDownV1.Name = "numericUpDownV1";
            this.numericUpDownV1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownV1.TabIndex = 7;
            // 
            // numericUpDownV2
            // 
            this.numericUpDownV2.DecimalPlaces = 1;
            this.numericUpDownV2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownV2.Location = new System.Drawing.Point(101, 695);
            this.numericUpDownV2.Name = "numericUpDownV2";
            this.numericUpDownV2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownV2.TabIndex = 8;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(409, 657);
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownX.TabIndex = 9;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 2;
            this.numericUpDownY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownY.Location = new System.Drawing.Point(409, 695);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownY.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 662);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 700);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Y:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 634);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 695);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 272);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Formula:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 752);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.numericUpDownV2);
            this.Controls.Add(this.numericUpDownV1);
            this.Controls.Add(this.comboBoxFunction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1041, 799);
            this.MinimumSize = new System.Drawing.Size(1041, 799);
            this.Name = "Form4";
            this.Text = "Reference System for PD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFunction;
        private System.Windows.Forms.NumericUpDown numericUpDownV1;
        private System.Windows.Forms.NumericUpDown numericUpDownV2;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}