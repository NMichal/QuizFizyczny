namespace QuizFizyczny.UserControls
{
    partial class UcQuiz
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBkonaRundy = new System.Windows.Forms.PictureBox();
            this.rBtnOdp1 = new System.Windows.Forms.RadioButton();
            this.rBtnOdp2 = new System.Windows.Forms.RadioButton();
            this.rBtnOdp3 = new System.Windows.Forms.RadioButton();
            this.rBtnOdp4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBPytanie = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDalej = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBkonaRundy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBkonaRundy
            // 
            this.pBkonaRundy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pBkonaRundy.Location = new System.Drawing.Point(333, 3);
            this.pBkonaRundy.Name = "pBkonaRundy";
            this.pBkonaRundy.Size = new System.Drawing.Size(161, 85);
            this.pBkonaRundy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBkonaRundy.TabIndex = 0;
            this.pBkonaRundy.TabStop = false;
            // 
            // rBtnOdp1
            // 
            this.rBtnOdp1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rBtnOdp1.AutoSize = true;
            this.rBtnOdp1.Location = new System.Drawing.Point(26, 35);
            this.rBtnOdp1.Name = "rBtnOdp1";
            this.rBtnOdp1.Size = new System.Drawing.Size(14, 13);
            this.rBtnOdp1.TabIndex = 1;
            this.rBtnOdp1.TabStop = true;
            this.rBtnOdp1.UseVisualStyleBackColor = true;
            // 
            // rBtnOdp2
            // 
            this.rBtnOdp2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rBtnOdp2.AutoSize = true;
            this.rBtnOdp2.Location = new System.Drawing.Point(26, 108);
            this.rBtnOdp2.Name = "rBtnOdp2";
            this.rBtnOdp2.Size = new System.Drawing.Size(14, 13);
            this.rBtnOdp2.TabIndex = 2;
            this.rBtnOdp2.TabStop = true;
            this.rBtnOdp2.UseVisualStyleBackColor = true;
            // 
            // rBtnOdp3
            // 
            this.rBtnOdp3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rBtnOdp3.AutoSize = true;
            this.rBtnOdp3.Location = new System.Drawing.Point(512, 35);
            this.rBtnOdp3.Name = "rBtnOdp3";
            this.rBtnOdp3.Size = new System.Drawing.Size(14, 13);
            this.rBtnOdp3.TabIndex = 3;
            this.rBtnOdp3.TabStop = true;
            this.rBtnOdp3.UseVisualStyleBackColor = true;
            // 
            // rBtnOdp4
            // 
            this.rBtnOdp4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rBtnOdp4.AutoSize = true;
            this.rBtnOdp4.Location = new System.Drawing.Point(512, 108);
            this.rBtnOdp4.Name = "rBtnOdp4";
            this.rBtnOdp4.Size = new System.Drawing.Size(14, 13);
            this.rBtnOdp4.TabIndex = 4;
            this.rBtnOdp4.TabStop = true;
            this.rBtnOdp4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TBPytanie);
            this.groupBox1.Location = new System.Drawing.Point(3, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pytanie";
            // 
            // TBPytanie
            // 
            this.TBPytanie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBPytanie.Location = new System.Drawing.Point(22, 19);
            this.TBPytanie.Multiline = true;
            this.TBPytanie.Name = "TBPytanie";
            this.TBPytanie.ReadOnly = true;
            this.TBPytanie.Size = new System.Drawing.Size(812, 70);
            this.TBPytanie.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rBtnOdp2);
            this.groupBox2.Controls.Add(this.rBtnOdp1);
            this.groupBox2.Controls.Add(this.rBtnOdp3);
            this.groupBox2.Controls.Add(this.rBtnOdp4);
            this.groupBox2.Location = new System.Drawing.Point(3, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(819, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Odpowiedzi";
            // 
            // BtnDalej
            // 
            this.BtnDalej.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDalej.Location = new System.Drawing.Point(755, 554);
            this.BtnDalej.Name = "BtnDalej";
            this.BtnDalej.Size = new System.Drawing.Size(112, 32);
            this.BtnDalej.TabIndex = 7;
            this.BtnDalej.Text = "Dalej";
            this.BtnDalej.UseVisualStyleBackColor = true;
            this.BtnDalej.Click += new System.EventHandler(this.BtnDalej_Click);
            // 
            // UcQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDalej);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pBkonaRundy);
            this.MinimumSize = new System.Drawing.Size(680, 573);
            this.Name = "UcQuiz";
            this.Size = new System.Drawing.Size(870, 589);
            ((System.ComponentModel.ISupportInitialize)(this.pBkonaRundy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBkonaRundy;
        private System.Windows.Forms.RadioButton rBtnOdp1;
        private System.Windows.Forms.RadioButton rBtnOdp2;
        private System.Windows.Forms.RadioButton rBtnOdp3;
        private System.Windows.Forms.RadioButton rBtnOdp4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBPytanie;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDalej;
    }
}
