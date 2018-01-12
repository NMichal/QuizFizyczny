namespace QuizFizyczny.Forms
{
    partial class MenuStart
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
            this.bttnSingle = new System.Windows.Forms.Button();
            this.bttnMulti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnSingle
            // 
            this.bttnSingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnSingle.Location = new System.Drawing.Point(62, 110);
            this.bttnSingle.Name = "bttnSingle";
            this.bttnSingle.Size = new System.Drawing.Size(162, 46);
            this.bttnSingle.TabIndex = 2;
            this.bttnSingle.Text = "Jeden gracz";
            this.bttnSingle.UseVisualStyleBackColor = true;
            this.bttnSingle.Click += new System.EventHandler(this.bttnSingle_Click);
            // 
            // bttnMulti
            // 
            this.bttnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bttnMulti.Location = new System.Drawing.Point(62, 188);
            this.bttnMulti.Name = "bttnMulti";
            this.bttnMulti.Size = new System.Drawing.Size(162, 46);
            this.bttnMulti.TabIndex = 3;
            this.bttnMulti.Text = "Wielu graczy";
            this.bttnMulti.UseVisualStyleBackColor = true;
            this.bttnMulti.Click += new System.EventHandler(this.bttnMulti_Click);
            // 
            // MenuStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bttnMulti);
            this.Controls.Add(this.bttnSingle);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MenuStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnSingle;
        private System.Windows.Forms.Button bttnMulti;
    }
}