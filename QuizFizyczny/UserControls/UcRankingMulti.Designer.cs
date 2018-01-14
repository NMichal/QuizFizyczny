namespace QuizFizyczny.UserControls
{
    partial class UcRankingMulti
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.cHLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHRezultat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHIloscGier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnWroc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHLogin,
            this.cHRezultat,
            this.cHIloscGier});
            this.listView1.Location = new System.Drawing.Point(209, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 513);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cHLogin
            // 
            this.cHLogin.Text = "Login";
            this.cHLogin.Width = 101;
            // 
            // cHRezultat
            // 
            this.cHRezultat.Text = "Ilość punktów";
            this.cHRezultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHRezultat.Width = 119;
            // 
            // cHIloscGier
            // 
            this.cHIloscGier.Text = "Ilość gier";
            this.cHIloscGier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnWroc
            // 
            this.BtnWroc.Location = new System.Drawing.Point(3, 3);
            this.BtnWroc.Name = "BtnWroc";
            this.BtnWroc.Size = new System.Drawing.Size(99, 34);
            this.BtnWroc.TabIndex = 3;
            this.BtnWroc.Text = "<- WRÓĆ";
            this.BtnWroc.UseVisualStyleBackColor = true;
            this.BtnWroc.Click += new System.EventHandler(this.BtnWroc_Click);
            // 
            // UcRankingMulti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnWroc);
            this.Controls.Add(this.listView1);
            this.Name = "UcRankingMulti";
            this.Size = new System.Drawing.Size(766, 612);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cHLogin;
        private System.Windows.Forms.ColumnHeader cHRezultat;
        private System.Windows.Forms.ColumnHeader cHIloscGier;
        private System.Windows.Forms.Button BtnWroc;
    }
}
