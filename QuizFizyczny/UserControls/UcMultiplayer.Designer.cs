namespace QuizFizyczny.UserControls
{
    partial class UcMultiplayer
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
            this.BtnPlayMulti = new System.Windows.Forms.Button();
            this.BtnWyniki = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnMojeWyniki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPlayMulti
            // 
            this.BtnPlayMulti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPlayMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPlayMulti.Location = new System.Drawing.Point(242, 3);
            this.BtnPlayMulti.Name = "BtnPlayMulti";
            this.BtnPlayMulti.Size = new System.Drawing.Size(234, 56);
            this.BtnPlayMulti.TabIndex = 0;
            this.BtnPlayMulti.Text = "Graj";
            this.BtnPlayMulti.UseVisualStyleBackColor = true;
            this.BtnPlayMulti.Click += new System.EventHandler(this.BtnPlayMulti_Click);
            // 
            // BtnWyniki
            // 
            this.BtnWyniki.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnWyniki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnWyniki.Location = new System.Drawing.Point(242, 453);
            this.BtnWyniki.Name = "BtnWyniki";
            this.BtnWyniki.Size = new System.Drawing.Size(234, 52);
            this.BtnWyniki.TabIndex = 1;
            this.BtnWyniki.Text = "Ranking";
            this.BtnWyniki.UseVisualStyleBackColor = true;
            this.BtnWyniki.Click += new System.EventHandler(this.BtnWyniki_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(122, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Graj z ludźmi z całego świata i pogłębiaj fizyczną wiedzę!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.Image = global::QuizFizyczny.Properties.Resources.icons8_physics_96;
            this.pictureBox2.Location = new System.Drawing.Point(35, 422);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QuizFizyczny.Properties.Resources.icons8_online_96;
            this.pictureBox1.Location = new System.Drawing.Point(654, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BtnMojeWyniki
            // 
            this.BtnMojeWyniki.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnMojeWyniki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnMojeWyniki.Location = new System.Drawing.Point(571, 453);
            this.BtnMojeWyniki.Name = "BtnMojeWyniki";
            this.BtnMojeWyniki.Size = new System.Drawing.Size(234, 52);
            this.BtnMojeWyniki.TabIndex = 5;
            this.BtnMojeWyniki.Text = "Rezultaty";
            this.BtnMojeWyniki.UseVisualStyleBackColor = true;
            this.BtnMojeWyniki.Click += new System.EventHandler(this.BtnMojeWyniki_Click);
            // 
            // UcMultiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnMojeWyniki);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnWyniki);
            this.Controls.Add(this.BtnPlayMulti);
            this.Name = "UcMultiplayer";
            this.Size = new System.Drawing.Size(808, 508);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlayMulti;
        private System.Windows.Forms.Button BtnWyniki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnMojeWyniki;
    }
}
