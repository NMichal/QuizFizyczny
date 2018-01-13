namespace QuizFizyczny.UserControls
{
    partial class UcSingleplayer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnGraj = new System.Windows.Forms.Button();
            this.bttnWszystkieWyniki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(209, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pobijaj rekordy innych graczy!";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(209, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Najlepsze wyniki:";
            // 
            // bttnGraj
            // 
            this.bttnGraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnGraj.Location = new System.Drawing.Point(262, 11);
            this.bttnGraj.Name = "bttnGraj";
            this.bttnGraj.Size = new System.Drawing.Size(234, 83);
            this.bttnGraj.TabIndex = 5;
            this.bttnGraj.Text = "Graj";
            this.bttnGraj.UseVisualStyleBackColor = true;
            this.bttnGraj.Click += new System.EventHandler(this.bttnGraj_Click);
            // 
            // bttnWszystkieWyniki
            // 
            this.bttnWszystkieWyniki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnWszystkieWyniki.Location = new System.Drawing.Point(262, 404);
            this.bttnWszystkieWyniki.Name = "bttnWszystkieWyniki";
            this.bttnWszystkieWyniki.Size = new System.Drawing.Size(234, 83);
            this.bttnWszystkieWyniki.TabIndex = 6;
            this.bttnWszystkieWyniki.Text = "Wszystkie wyniki";
            this.bttnWszystkieWyniki.UseVisualStyleBackColor = true;
            this.bttnWszystkieWyniki.Click += new System.EventHandler(this.bttnWszystkieWyniki_Click);
            // 
            // UcSingleplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttnWszystkieWyniki);
            this.Controls.Add(this.bttnGraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UcSingleplayer";
            this.Size = new System.Drawing.Size(808, 508);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnGraj;
        private System.Windows.Forms.Button bttnWszystkieWyniki;
    }
}
