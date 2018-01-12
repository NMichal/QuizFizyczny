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
            //masz pzygotowane MICHAŁ :D

            //UcSingleplayer ucSingle = new UcSingleplayer();
            //ucSingle.Dock = DockStyle.Fill;
            
        }

        private void bttnMulti_Click(object sender, EventArgs e)
        {
            UcMultiplayer ucMulti = new UcMultiplayer();
            ucMulti.Dock = DockStyle.Fill;
            ustawPanelZTrybem(ucMulti);
        }

        private void ustawPanelZTrybem(UserControl userControl)
        {
            panelGame.Controls.Clear();

            panelGame.Controls.Add(userControl);
        }
    }
}
