using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizFizyczny.DataBase;
using QuizFizyczny.Forms;

namespace QuizFizyczny.UserControls
{
    public partial class UcSingleplayer : UserControl
    {
        private MenuStart _parent;
        public UcSingleplayer(MenuStart parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void bttnGraj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Za chwilę rozpoczniesz nową grę! Im szybsza odpowiedź tym więcej punktów. Powodzenia!", "Rozpocznij grę");
            List<int> oidPytan = losujPytania(5);
            UcQuizSingle quizSingle = new UcQuizSingle(oidPytan);
            quizSingle.Dock = DockStyle.Fill;
            _parent.ustawPanelZTrybem(quizSingle);

        }

        private void bttnWszystkieWyniki_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Losuje z bazy danych określoną ilość pytań
        /// </summary>
        /// <param name="ilePytan">parametr ile pytań ma zostać wylosowane</param>
        /// <returns>Lista wylosowanych pytań</returns>
        private List<int> losujPytania(int ilePytan)
        {
            List<int> listOidPytan = new List<int>();
            listOidPytan = ContextDb.contextDB.Pytania.Select(a => a.id).ToList();

            Random rand = new Random();
            listOidPytan = listOidPytan.OrderBy(x => rand.Next()).ToList();
            return listOidPytan.Take(ilePytan).ToList();
        }
    }
}
