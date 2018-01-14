namespace QuizFizyczny.Forms
{
    partial class FrmLoginRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginRegister));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPLogin = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbHaslo = new System.Windows.Forms.TextBox();
            this.TbLogin = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TPRegister = new System.Windows.Forms.TabPage();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TbPowtozHaslo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbHasloRegister = new System.Windows.Forms.TextBox();
            this.TbLoginRegister = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.TPLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TPRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPLogin);
            this.tabControl1.Controls.Add(this.TPRegister);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 315);
            this.tabControl1.TabIndex = 0;
            // 
            // TPLogin
            // 
            this.TPLogin.Controls.Add(this.pictureBox1);
            this.TPLogin.Controls.Add(this.label2);
            this.TPLogin.Controls.Add(this.label1);
            this.TPLogin.Controls.Add(this.TbHaslo);
            this.TPLogin.Controls.Add(this.TbLogin);
            this.TPLogin.Controls.Add(this.BtnLogin);
            this.TPLogin.Location = new System.Drawing.Point(4, 27);
            this.TPLogin.Name = "TPLogin";
            this.TPLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TPLogin.Size = new System.Drawing.Size(589, 284);
            this.TPLogin.TabIndex = 0;
            this.TPLogin.Text = "Logowanie";
            this.TPLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(228, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(120, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasło";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // TbHaslo
            // 
            this.TbHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbHaslo.Location = new System.Drawing.Point(169, 168);
            this.TbHaslo.Name = "TbHaslo";
            this.TbHaslo.PasswordChar = '*';
            this.TbHaslo.Size = new System.Drawing.Size(226, 24);
            this.TbHaslo.TabIndex = 2;
            // 
            // TbLogin
            // 
            this.TbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLogin.Location = new System.Drawing.Point(169, 123);
            this.TbLogin.Name = "TbLogin";
            this.TbLogin.Size = new System.Drawing.Size(226, 24);
            this.TbLogin.TabIndex = 1;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnLogin.Location = new System.Drawing.Point(491, 245);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(90, 31);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Zaloguj i graj!";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TPRegister
            // 
            this.TPRegister.Controls.Add(this.BtnRegister);
            this.TPRegister.Controls.Add(this.label5);
            this.TPRegister.Controls.Add(this.TbPowtozHaslo);
            this.TPRegister.Controls.Add(this.label3);
            this.TPRegister.Controls.Add(this.label4);
            this.TPRegister.Controls.Add(this.TbHasloRegister);
            this.TPRegister.Controls.Add(this.TbLoginRegister);
            this.TPRegister.Location = new System.Drawing.Point(4, 27);
            this.TPRegister.Name = "TPRegister";
            this.TPRegister.Padding = new System.Windows.Forms.Padding(3);
            this.TPRegister.Size = new System.Drawing.Size(589, 284);
            this.TPRegister.TabIndex = 1;
            this.TPRegister.Text = "Rejestracja";
            this.TPRegister.UseVisualStyleBackColor = true;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRegister.Location = new System.Drawing.Point(491, 245);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(90, 31);
            this.BtnRegister.TabIndex = 11;
            this.BtnRegister.Text = "Zarejestruj";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(14, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Powtórz hasło";
            // 
            // TbPowtozHaslo
            // 
            this.TbPowtozHaslo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbPowtozHaslo.Location = new System.Drawing.Point(116, 89);
            this.TbPowtozHaslo.Name = "TbPowtozHaslo";
            this.TbPowtozHaslo.PasswordChar = '*';
            this.TbPowtozHaslo.Size = new System.Drawing.Size(226, 24);
            this.TbPowtozHaslo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(47, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasło";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(47, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login";
            // 
            // TbHasloRegister
            // 
            this.TbHasloRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbHasloRegister.Location = new System.Drawing.Point(116, 51);
            this.TbHasloRegister.Name = "TbHasloRegister";
            this.TbHasloRegister.PasswordChar = '*';
            this.TbHasloRegister.Size = new System.Drawing.Size(226, 24);
            this.TbHasloRegister.TabIndex = 6;
            // 
            // TbLoginRegister
            // 
            this.TbLoginRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLoginRegister.Location = new System.Drawing.Point(116, 6);
            this.TbLoginRegister.Name = "TbLoginRegister";
            this.TbLoginRegister.Size = new System.Drawing.Size(226, 24);
            this.TbLoginRegister.TabIndex = 5;
            // 
            // FrmLoginRegister
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 315);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(613, 354);
            this.Name = "FrmLoginRegister";
            this.Text = "FrmLogin";
            this.tabControl1.ResumeLayout(false);
            this.TPLogin.ResumeLayout(false);
            this.TPLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TPRegister.ResumeLayout(false);
            this.TPRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPLogin;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TabPage TPRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbHaslo;
        private System.Windows.Forms.TextBox TbLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbPowtozHaslo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbHasloRegister;
        private System.Windows.Forms.TextBox TbLoginRegister;
    }
}