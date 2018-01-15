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
        List<Label> labelList;
        public UcSingleplayer(MenuStart parent)
        {
            InitializeComponent();
            labelList = new List<Label>(new Label[] { label3, label4, label5, label6, label7 });
            WyswietlTop5();
            _parent = parent;
        }

        private void bttnGraj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Za chwilę rozpoczniesz nową grę! Im szybsza odpowiedź tym więcej punktów. Powodzenia!", "Rozpocznij grę");
            List<int> oidPytan = losujPytania(5);
            UcQuizSingle quizSingle = new UcQuizSingle(_parent, oidPytan);
            quizSingle.Dock = DockStyle.Fill;
            _parent.ustawPanelZTrybem(quizSingle);

        }

        private void bttnWszystkieWyniki_Click(object sender, EventArgs e)
        {
            UcRankingSingle rankingSingle = new UcRankingSingle(_parent);
            rankingSingle.Dock = DockStyle.Fill;
            _parent.ustawPanelZTrybem(rankingSingle);
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

        private void WyswietlTop5()
        {
            int i = 0;
            List<RankingSingle> rankSing = ContextDb.contextDB.RankingSingle.OrderByDescending(a => a.punkty).ToList();
            foreach (RankingSingle rk in rankSing)
            {
                Uzytkownicy uzytk = ContextDb.contextDB.Uzytkownicy.Where(a => a.id == rk.idGracza).FirstOrDefault();
                string tekst = string.Format("{0}. {1} - {2} pkt", (i+1).ToString(), uzytk.login, rk.punkty.ToString());
                labelList[i].Text = tekst;
                i++;
            }
        }
    }
}
