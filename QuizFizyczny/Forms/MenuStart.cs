using QuizFizyczny.Class;
using QuizFizyczny.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFizyczny.Forms
{
    public partial class MenuStart : Form
    {
        public MenuStart()
        {
            InitializeComponent();
            lLogin.Text = ContextApp.LoginUzytko;
        }

        private void bttnSingle_Click(object sender, EventArgs e)
        {
            UcSingleplayer ucSingle = new UcSingleplayer(this);
            ucSingle.Dock = DockStyle.Fill;
            ustawPanelZTrybem(ucSingle);
        }

        private void bttnMulti_Click(object sender, EventArgs e)
        {
            UcMultiplayer ucMulti = new UcMultiplayer(this);
            ustawPanelZTrybem(ucMulti);
        }
        
        public void ustawPanelZTrybem(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelGame.Controls.Clear();

            panelGame.Controls.Add(userControl);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);        
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            //Environment.Exit(0);
            Application.Exit();

            
        }
    }
}
