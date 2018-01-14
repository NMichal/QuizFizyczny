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
using System.IO;
using System.Media;
using QuizFizyczny.Class;

namespace QuizFizyczny.UserControls
{
    public partial class UcQuiz : UserControl
    { 
        int _counter, iloscOdpowiedzi = 0;
        const int remis = 1;
        const int wygrana = 3;

        List<Pytania> _obiektPytania;
        List<Odpowiedzi> _odpowiedzi;
        List<PoprawneOdpowiedzi> _poprawOdp;
        MenuStart _parent;
        Rozgrywka _rozgrywka;
        RozgrywkaOdp _rozgrywkaOpd = new RozgrywkaOdp();
        int idPytania;
        bool _dolaczanie;
        
        Bitmap[] ikonyRund = new Bitmap[]
        {
            Properties.Resources.pyt1,
            Properties.Resources.pyt2,
            Properties.Resources.pyt3,
        };

        public UcQuiz(List<Pytania> pytania, List<Odpowiedzi> odpowiedzi, List<PoprawneOdpowiedzi> poprawOdp, MenuStart parent, Rozgrywka rozgrywka, bool dolaczanie = false)
        {
            InitializeComponent();

            _dolaczanie = dolaczanie;
            _obiektPytania = pytania;
            _odpowiedzi = odpowiedzi;
            _poprawOdp = poprawOdp;
            _parent = parent;
            _rozgrywka = rozgrywka;
            przygotujRunde(_counter);

            _rozgrywkaOpd.idRozgrywki = rozgrywka.id;
            _rozgrywkaOpd.iduzt = ContextApp.IdUzytko;

        }

        private void BtnDalej_Click(object sender, EventArgs e)
        {
            string odpowiedz;
            if (!sprawdzOdpowiedz(out odpowiedz))
                blednaOdpowiedz();
            else
                dobraOdpowiedz();

            if (_counter < 2)
            {
                przygotujRunde(++_counter);
            }
            else
                zakonczQuiz();
        }

        /// <summary>
        /// Metoda wywołująca się po dobrze udzielonej odpowiedzi przez użytkownika
        /// </summary>
        private void dobraOdpowiedz()
        {
            iloscOdpowiedzi++;
            try
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.dobaOdp);
                sound.Play();
            }
            catch(Exception exp)
            {

            }
        }

        /// <summary>
        /// Metoda wywołująca się po złej dpowiedzi udzielonej przez użytkownika
        /// </summary>
        private void blednaOdpowiedz()
        {
            try
            {
                SoundPlayer sound = new SoundPlayer(Properties.Resources.blednaOdp);
                sound.Play();
            }
            catch (Exception exp)
            {

            }
        }

        /// <summary>
        /// Metoda sprawdzająca czy użytkownik odpowiedział poprawnie na pytanie.
        /// </summary>
        /// <param name="odpowiedz">Out, prawidłowa odpowiedz na pytanie</param>
        /// <returns>True jeżeli odpowiedz jest prawidłowa, w przeciwnym wypadku False</returns>
        private bool sprawdzOdpowiedz(out string odpowiedz)
        {
            var poprwOdp = _obiektPytania[_counter].PoprawneOdpowiedzi.First().Odpowiedzi;
            
            odpowiedz = poprwOdp.odpowiedz;

            if (rBtnOdp1.Checked )
            {
                zapiszOdpowiedzUzytkownika(0);
                if(odpowiedz == rBtnOdp1.Text)
                    return true;
            }

            else if (rBtnOdp2.Checked)
            {
                zapiszOdpowiedzUzytkownika(1);

                if (odpowiedz == rBtnOdp2.Text)
                    return true;
            }
                

            else if (rBtnOdp3.Checked)
            {
                zapiszOdpowiedzUzytkownika(2);

                if (odpowiedz == rBtnOdp3.Text)
                    return true;
            }


            else if (rBtnOdp4.Checked)
            {
                zapiszOdpowiedzUzytkownika(3);

                if(odpowiedz == rBtnOdp4.Text)
                    return true;
            }


            return false;
        }

        /// <summary>
        /// Zapsuje wybraną odpowiedź użytkownika do bazy.
        /// </summary>
        /// <param name="indexOdp">Index odpowiedzi w liscie odpowiedzi</param>
        private void zapiszOdpowiedzUzytkownika(int indexOdp)
        {

            switch(_counter)
            {
                case 0:
                    _rozgrywkaOpd.idodp1 = _odpowiedzi.Where(x => x.id_pytanie == idPytania).ToList()[indexOdp].id;
                    break;
                case 1:
                    _rozgrywkaOpd.idodp2 = _odpowiedzi.Where(x => x.id_pytanie == idPytania).ToList()[indexOdp].id;
                    break;
                case 2:
                    _rozgrywkaOpd.idodp3 = _odpowiedzi.Where(x => x.id_pytanie == idPytania).ToList()[indexOdp].id;
                    break;

            }            
        }

        /// <summary>
        /// Metoda przygotowująca pytanie oraz odpowiedzi
        /// </summary>
        /// <param name="counter">Licznik rundy. Maks. 2</param>
        private void przygotujRunde(int counter)
        {
            rBtnOdp1.Checked = rBtnOdp2.Checked = rBtnOdp3.Checked = rBtnOdp4.Checked = false;

            pBkonaRundy.Image = ikonyRund[counter];
            var pytanie = _obiektPytania[counter];

            idPytania = pytanie.id;

            TBPytanie.Text = pytanie.trescPytania;

            var odpowiedzi = _odpowiedzi.Where(x => x.id_pytanie == idPytania).ToList();

            rBtnOdp1.Text = odpowiedzi[0].odpowiedz;
            rBtnOdp2.Text = odpowiedzi[1].odpowiedz;
            rBtnOdp3.Text = odpowiedzi[2].odpowiedz;
            rBtnOdp4.Text = odpowiedzi[3].odpowiedz;

        }

        /// <summary>
        /// Metoda wywołuje się gdy użytkownik odpowie na ostatnie pytanie.
        /// Podlicza punkty i wstawia do bazy. Jeżeli rozgrywka jest zakończona informuje o wyniku.
        /// </summary>
        private void zakonczQuiz()
        {
            _rozgrywkaOpd.punkty = iloscOdpowiedzi;
            ContextDb.contextDB.RozgrywkaOdp.Add(_rozgrywkaOpd);
            ContextDb.contextDB.SaveChanges();
            if(_dolaczanie)
                aktualizujRanking(iloscOdpowiedzi);

            MessageBox.Show(string.Format("Rozgrywka zakończona.\nZebrane punkty: {0}", iloscOdpowiedzi), "Koniec rozgrywki!");
            _parent.ustawPanelZTrybem(new UcMultiplayer(_parent));
        }

        private void aktualizujRanking(int punktyGracza)
        {
            bool? wygranaGracza = null;
            var przeciwnik = ContextDb.contextDB.RozgrywkaOdp.Where(x => x.idRozgrywki == _rozgrywka.id && x.iduzt != ContextApp.IdUzytko).First();

            if (przeciwnik.punkty > punktyGracza)
                wygranaGracza = false;
            else if (przeciwnik.punkty < punktyGracza)
                wygranaGracza = true;
            
            if(wygranaGracza == null)
            {
                //remis
                dodajDoRangingu(ContextApp.IdUzytko, remis);
                dodajDoRangingu(przeciwnik.iduzt, remis);
            }
            else
            {
                //jest jeden wygrany
                if(wygranaGracza == true)
                {
                    dodajDoRangingu(ContextApp.IdUzytko, wygrana);
                    dodajDoRangingu(przeciwnik.iduzt, 0);
                }
                else
                {
                    dodajDoRangingu(ContextApp.IdUzytko, 0);
                    dodajDoRangingu(przeciwnik.iduzt, wygrana);
                }

            }
        }

        /// <summary>
        /// Aktualizuje ranking dla id podanego gracza
        /// </summary>
        /// <param name="idGracza"></param>
        /// <param name="iloscPunktow"></param>
        private void dodajDoRangingu(int idGracza, int iloscPunktow)
        {
            var ranking = ContextDb.contextDB.RankingMulti.Where(x => x.idGracza == idGracza).FirstOrDefault();

            if (ranking == null)
            {
                ranking = nowyRanking(idGracza);
                ContextDb.contextDB.RankingMulti.Add(ranking);
                ContextDb.contextDB.SaveChanges();
            }

            ranking.iloscGier = ++ranking.iloscGier;
            ranking.punkty = ranking.punkty + iloscPunktow;

            ContextDb.contextDB.SaveChanges();
        }

        /// <summary>
        /// Zwraca nowy obiekt z rankingiem dla gracza, którego nie ma rankingu
        /// </summary>
        /// <param name="idGracza"></param>
        /// <returns></returns>
        private RankingMulti nowyRanking(int idGracza)
        {
            return new RankingMulti() { idGracza = idGracza, iloscGier = 0, punkty = 0};
        }
    }
}
