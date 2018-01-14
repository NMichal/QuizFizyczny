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
using System.Diagnostics;
using System.Media;
using QuizFizyczny.Forms;
using QuizFizyczny.Class;

namespace QuizFizyczny.UserControls
{
    public partial class UcQuizSingle : UserControl
    {
        MenuStart _parent;
        List<int> listOidPytan = null;
        int liczbaPytan = 0;
        int aktualnyNumerPytania = 0;
        List<RadioButton> listRB;
        Pytania aktualnePytanieObj;
        int lacznaLiczbaPunktow = 0;
        Stopwatch czasOdpowiedzi = new Stopwatch();
        public UcQuizSingle(MenuStart parent, List<int> oidPytania)
        {
            InitializeComponent();
            _parent = parent;
            listRB = new List<RadioButton>(new RadioButton[] { radioButton1, radioButton2, radioButton3, radioButton4 });
            listOidPytan = oidPytania;
            liczbaPytan = oidPytania.Count;
            WyswietlPytanie(aktualnyNumerPytania);
        }

        public void WyswietlPytanie(int numerPytania)
        {
            int oidPytania = listOidPytan[numerPytania];
            aktualnePytanieObj = ContextDb.contextDB.Pytania.Where(a => a.id == oidPytania).FirstOrDefault();
            textBoxPytanie.Text = aktualnePytanieObj.trescPytania;
            int rbcount = 0;
            //dodobić mieszanie odpowiedzi
            foreach (var item in aktualnePytanieObj.Odpowiedzi)
            {
                listRB[rbcount].Text = item.odpowiedz;
                listRB[rbcount].Checked = false; //Odznaczenie poprzedniej odpowiedzi
                rbcount++;
            }
            czasOdpowiedzi.Restart();
        }

        private void bttnOdpowiedz_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                czasOdpowiedzi.Stop();
                Console.WriteLine("Time elapsed: {0}", czasOdpowiedzi.ElapsedMilliseconds);

                lacznaLiczbaPunktow += policzPunkty();

                if (aktualnyNumerPytania + 1 < liczbaPytan)
                {
                    aktualnyNumerPytania++;
                    WyswietlPytanie(aktualnyNumerPytania);
                    //czasOdpowiedzi.Reset();
                }
                else
                {
                    KoniecQuizu();
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć odpowiedź", "Nie wybrano odpowiedzi");
            }
        }

        private bool czyOdpPoprawna()
        {
            PoprawneOdpowiedzi poprawnaOdp = aktualnePytanieObj.PoprawneOdpowiedzi.ToArray()[0];
            Odpowiedzi odp = ContextDb.contextDB.Odpowiedzi.Where(a => a.id == poprawnaOdp.id_odpowiedzPytanie).FirstOrDefault();
            foreach (var radiobutton in listRB)
            {
                if (radiobutton.Checked)
                    if (radiobutton.Text == odp.odpowiedz)
                    {
                        try
                        {
                            SoundPlayer sound = new SoundPlayer(Properties.Resources.dobaOdp);
                            sound.Play();
                        }
                        catch { }
                        return true;
                    }
            }
            try
            {
                SoundPlayer sound2 = new SoundPlayer(Properties.Resources.blednaOdp);
                sound2.Play();
            }
            catch { }
            return false;
        }

        /// <summary>
        /// Metoda licząca punkty za poprawną odpowiedź, bazowa wartość 200pkt
        /// za poprawną odpowiedź, oraz za każdą sekundę - 10 pkt        
        /// </summary>
        /// <returns>liczba punktów za jedną odpowiedź</returns>
        private int policzPunkty()
        {
            int liczbaPkt = 300;
            if (czyOdpPoprawna())
            {
                Console.WriteLine("Time elapsed: {0}", czasOdpowiedzi.ElapsedMilliseconds);
                long miliSec = czasOdpowiedzi.ElapsedMilliseconds;
                double ujemnePunkty = miliSec / 100.0;
                liczbaPkt -= Convert.ToInt32(ujemnePunkty);
                //Policz punkty

                if (liczbaPkt < 0)
                    liczbaPkt = 0;
                return liczbaPkt;
            }
            else
            {
                liczbaPkt = 0;
                return liczbaPkt;
            }
        }

private void KoniecQuizu()
        {
            string tekstKoncowy;
            RankingSingle rs = ContextDb.contextDB.RankingSingle.Where(a => a.idGracza == ContextApp.IdUzytko).FirstOrDefault();
            if(rs != null)
            {                
                if(rs.punkty < lacznaLiczbaPunktow)
                {                    
                    tekstKoncowy = string.Format("Quiz zakończony, uzyskana liczba punktów: {0}. Pobito wcześniejszy wynik wynoszący {1}. Gratulacje!", lacznaLiczbaPunktow.ToString(), rs.punkty.ToString());
                    rs.punkty = lacznaLiczbaPunktow;
                    ContextDb.contextDB.SaveChanges();
                }
                else
                {
                    tekstKoncowy = string.Format("Quiz zakończony, uzyskana liczba punktów: {0}. Nie udało się pobić wcześniejszego wyniku wynoszącego {1}. Próbuj dalej!", lacznaLiczbaPunktow.ToString(), rs.punkty.ToString());
                }
            }
            else
            {
                RankingSingle noweRS = new RankingSingle()
                {
                    idGracza = ContextApp.IdUzytko,
                    punkty = lacznaLiczbaPunktow
                };

                ContextDb.contextDB.RankingSingle.Add(noweRS);
                ContextDb.contextDB.SaveChanges();
                tekstKoncowy = string.Format("Quiz zakończony, uzyskana liczba punktów: {0}", lacznaLiczbaPunktow.ToString());
            }
            
            MessageBox.Show(tekstKoncowy, "Koniec");
            //Liczba punktów: .... Zająłeś ... miejsce.
            //pobiłeś swój poprzedni wynik: ... punktów

            UcSingleplayer ucSingle = new UcSingleplayer(_parent);
            ucSingle.Dock = DockStyle.Fill;
            _parent.ustawPanelZTrybem(ucSingle);
        }
    }
}
