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
        }

        private void bttnSingle_Click(object sender, EventArgs e)
        {
            //UcSingleplayer ucSingle = new UcSingleplayer();
            //ucSingle.Dock = DockStyle.Fill;
            //ustawPanelZTrybem(ucSingle);
        }

        private void bttnMulti_Click(object sender, EventArgs e)
        {
            UcMultiplayer ucMulti = new UcMultiplayer(this);
            ///ucMulti.Dock = DockStyle.Fill;
            ustawPanelZTrybem(ucMulti);
        }
        
        public void ustawPanelZTrybem(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelGame.Controls.Clear();

            panelGame.Controls.Add(userControl);
        }
    }
}
