using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizFizyczny.Forms;
using QuizFizyczny.DataBase;

namespace QuizFizyczny.UserControls
{
    public partial class UcRankingMulti : UserControl
    {
        MenuStart _parent;
        public UcRankingMulti(MenuStart parent)
        {
            InitializeComponent();
            _parent = parent;

            przygotujRanking();
        }

        private void przygotujRanking()
        {
            var ranking = ContextDb.contextDB.RankingMulti.OrderByDescending(x => x.punkty).ThenBy(x => x.iloscGier);

            foreach (var item in ranking)
            {
                dodajDoRankingu(item.Uzytkownicy.login, item.iloscGier, item.punkty);
            }
        }

        /// <summary>
        /// Metoda dodająca użytkownika do listy rankingowej
        /// </summary>
        /// <param name="login"></param>
        /// <param name="iloscGier"></param>
        /// <param name="punkty"></param>
        private void dodajDoRankingu(string login, int iloscGier, int punkty)
        {
            string[] row = { login, punkty.ToString(), iloscGier.ToString() };

            var item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

        private void BtnWroc_Click(object sender, EventArgs e)
        {
            _parent.ustawPanelZTrybem(new UcMultiplayer(_parent));
        }
    }
}
