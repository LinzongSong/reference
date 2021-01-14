namespace SoftwareEngineeringNew
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCD = new System.Windows.Forms.Button();
            this.buttonDD = new System.Windows.Forms.Button();
            this.buttonReturnMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "select the distribution type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(104, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(461, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // buttonCD
            // 
            this.buttonCD.Location = new System.Drawing.Point(104, 290);
            this.buttonCD.Name = "buttonCD";
            this.buttonCD.Size = new System.Drawing.Size(209, 38);
            this.buttonCD.TabIndex = 3;
            this.buttonCD.Text = "Continuous distribution";
            this.buttonCD.UseVisualStyleBackColor = true;
            this.buttonCD.Click += new System.EventHandler(this.buttonCD_Click);
            // 
            // buttonDD
            // 
            this.buttonDD.Location = new System.Drawing.Point(461, 290);
            this.buttonDD.Name = "buttonDD";
            this.buttonDD.Size = new System.Drawing.Size(209, 38);
            this.buttonDD.TabIndex = 4;
            this.buttonDD.Text = "Discrete distribution";
            this.buttonDD.UseVisualStyleBackColor = true;
            this.buttonDD.Click += new System.EventHandler(this.buttonDD_Click);
            // 
            // buttonReturnMain
            // 
            this.buttonReturnMain.Location = new System.Drawing.Point(683, 404);
            this.buttonReturnMain.Name = "buttonReturnMain";
            this.buttonReturnMain.Size = new System.Drawing.Size(105, 35);
            this.buttonReturnMain.TabIndex = 5;
            this.buttonReturnMain.Text = "Return";
            this.buttonReturnMain.UseVisualStyleBackColor = true;
            this.buttonReturnMain.Click += new System.EventHandler(this.buttonReturnMain_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.buttonReturnMain);
            this.Controls.Add(this.buttonDD);
            this.Controls.Add(this.buttonCD);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(818, 498);
            this.MinimumSize = new System.Drawing.Size(818, 498);
            this.Name = "Form2";
            this.Text = "Reference System for PD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonCD;
        private System.Windows.Forms.Button buttonDD;
        private System.Windows.Forms.Button buttonReturnMain;
    }
}