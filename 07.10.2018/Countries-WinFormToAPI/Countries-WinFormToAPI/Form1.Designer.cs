namespace Countries_WinFormToAPI
{
    partial class Form1
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
            this.countriesCB = new System.Windows.Forms.ComboBox();
            this.countriesLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // countriesCB
            // 
            this.countriesCB.FormattingEnabled = true;
            this.countriesCB.Location = new System.Drawing.Point(253, 56);
            this.countriesCB.Name = "countriesCB";
            this.countriesCB.Size = new System.Drawing.Size(121, 21);
            this.countriesCB.TabIndex = 0;
            this.countriesCB.SelectedIndexChanged += new System.EventHandler(this.countriesCB_SelectedIndexChanged);
            // 
            // countriesLbl
            // 
            this.countriesLbl.AutoSize = true;
            this.countriesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.countriesLbl.Location = new System.Drawing.Point(80, 52);
            this.countriesLbl.Name = "countriesLbl";
            this.countriesLbl.Size = new System.Drawing.Size(167, 25);
            this.countriesLbl.TabIndex = 1;
            this.countriesLbl.Text = "Select Country";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.resultLbl.Location = new System.Drawing.Point(85, 107);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(48, 20);
            this.resultLbl.TabIndex = 2;
            this.resultLbl.Text = "result";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(435, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 154);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.countriesLbl);
            this.Controls.Add(this.countriesCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox countriesCB;
        private System.Windows.Forms.Label countriesLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

