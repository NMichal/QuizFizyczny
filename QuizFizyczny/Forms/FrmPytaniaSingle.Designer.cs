namespace QuizFizyczny.Forms
{
    partial class FrmPytaniaSingle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bttnOdpowiedz = new System.Windows.Forms.Button();
            this.bttnZakoncz = new System.Windows.Forms.Button();
            this.textBoxPytanie = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(13, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odpowiedzi";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 166);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 120);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // bttnOdpowiedz
            // 
            this.bttnOdpowiedz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnOdpowiedz.Location = new System.Drawing.Point(28, 318);
            this.bttnOdpowiedz.Name = "bttnOdpowiedz";
            this.bttnOdpowiedz.Size = new System.Drawing.Size(112, 37);
            this.bttnOdpowiedz.TabIndex = 0;
            this.bttnOdpowiedz.Text = "Odpowiedz";
            this.bttnOdpowiedz.UseVisualStyleBackColor = true;
            this.bttnOdpowiedz.Click += new System.EventHandler(this.bttnOdpowiedz_Click);
            // 
            // bttnZakoncz
            // 
            this.bttnZakoncz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnZakoncz.Location = new System.Drawing.Point(177, 318);
            this.bttnZakoncz.Name = "bttnZakoncz";
            this.bttnZakoncz.Size = new System.Drawing.Size(112, 37);
            this.bttnZakoncz.TabIndex = 1;
            this.bttnZakoncz.Text = "Zakończ";
            this.bttnZakoncz.UseVisualStyleBackColor = true;
            this.bttnZakoncz.Click += new System.EventHandler(this.bttnZakoncz_Click);
            // 
            // textBoxPytanie
            // 
            this.textBoxPytanie.Location = new System.Drawing.Point(13, 12);
            this.textBoxPytanie.Multiline = true;
            this.textBoxPytanie.Name = "textBoxPytanie";
            this.textBoxPytanie.ReadOnly = true;
            this.textBoxPytanie.Size = new System.Drawing.Size(296, 66);
            this.textBoxPytanie.TabIndex = 2;
            // 
            // FrmPytaniaSingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 367);
            this.Controls.Add(this.textBoxPytanie);
            this.Controls.Add(this.bttnOdpowiedz);
            this.Controls.Add(this.bttnZakoncz);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPytaniaSingle";
            this.Text = "FrmPytaniaSingle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnOdpowiedz;
        private System.Windows.Forms.Button bttnZakoncz;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBoxPytanie;
    }
}