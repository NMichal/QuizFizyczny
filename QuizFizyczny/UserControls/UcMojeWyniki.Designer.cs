namespace QuizFizyczny.UserControls
{
    partial class UcMojeWyniki
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
            this.BtnWroc = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cHTwojWynik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHPrzeciwnik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHWynikPzeciwnik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHRezultat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnWroc
            // 
            this.BtnWroc.Location = new System.Drawing.Point(3, 3);
            this.BtnWroc.Name = "BtnWroc";
            this.BtnWroc.Size = new System.Drawing.Size(99, 34);
            this.BtnWroc.TabIndex = 0;
            this.BtnWroc.Text = "<- WRÓĆ";
            this.BtnWroc.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHPrzeciwnik,
            this.cHTwojWynik,
            this.cHWynikPzeciwnik,
            this.cHRezultat});
            this.listView1.Location = new System.Drawing.Point(282, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(439, 513);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cHTwojWynik
            // 
            this.cHTwojWynik.DisplayIndex = 0;
            this.cHTwojWynik.Text = "Twój wynik";
            this.cHTwojWynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHTwojWynik.Width = 90;
            // 
            // cHPrzeciwnik
            // 
            this.cHPrzeciwnik.DisplayIndex = 1;
            this.cHPrzeciwnik.Text = "Login pzeciwnika";
            this.cHPrzeciwnik.Width = 101;
            // 
            // cHWynikPzeciwnik
            // 
            this.cHWynikPzeciwnik.Text = "Wynik Pzeciwnika";
            this.cHWynikPzeciwnik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHWynikPzeciwnik.Width = 107;
            // 
            // cHRezultat
            // 
            this.cHRezultat.Text = "Rezultat";
            this.cHRezultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cHRezultat.Width = 119;
            // 
            // UcMojeWyniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BtnWroc);
            this.Name = "UcMojeWyniki";
            this.Size = new System.Drawing.Size(1050, 531);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnWroc;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cHPrzeciwnik;
        private System.Windows.Forms.ColumnHeader cHTwojWynik;
        private System.Windows.Forms.ColumnHeader cHWynikPzeciwnik;
        private System.Windows.Forms.ColumnHeader cHRezultat;
    }
}
