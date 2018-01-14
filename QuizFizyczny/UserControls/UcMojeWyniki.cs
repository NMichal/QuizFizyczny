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
using QuizFizyczny.Class;

namespace QuizFizyczny.UserControls
{
    public partial class UcMojeWyniki : UserControl
    {
        MenuStart _parent;
        public UcMojeWyniki(MenuStart parent)
        {
            InitializeComponent();
            _parent = parent;
            przygotujListeWynikow();
        }

        /// <summary>
        /// Metoda przygotowująca listę wyników.
        /// </summary>
        private void przygotujListeWynikow()
        {
            var rozgrywki = ContextDb.contextDB.Rozgrywka.Where(x => (x.idUztk1 == ContextApp.IdUzytko || x.idUztk2 == ContextApp.IdUzytko) && x.idUztk2 != null).ToList();

            foreach (var item in rozgrywki)
            {
                int wynik = item.RozgrywkaOdp.Where(x => x.iduzt == ContextApp.IdUzytko).Select(x => x.punkty).First();

                var przeciwnik = item.RozgrywkaOdp.Where(x => x.iduzt != ContextApp.IdUzytko).First();
                string loginPrzeciwnika = przeciwnik.Uzytkownicy.login;
                int wynikPrzeciwnika = przeciwnik.punkty;

                dodajDoListView(wynik, loginPrzeciwnika, wynikPrzeciwnika);
            }
        }

        /// <summary>
        /// Metoda dodająca elementy do list view
        /// </summary>
        /// <param name="wynik">Wynik zalogowanego użytkownika</param>
        /// <param name="loginPrzeciwnika">Login przeciwnika</param>
        /// <param name="wynikPzeciwnika">Wynik pzeciwnika</param>
        private void dodajDoListView(int wynik, string loginPrzeciwnika, int wynikPzeciwnika)
        {
            string rezultat;
            if (wynik > wynikPzeciwnika)
                rezultat = "Wygrana";
            else if (wynik < wynikPzeciwnika)
                rezultat = "Porażka";
            else
                rezultat = "Remis";

            string[] row = { loginPrzeciwnika.ToString(), wynik.ToString(), wynikPzeciwnika.ToString(), rezultat };

            var item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
    }
}
