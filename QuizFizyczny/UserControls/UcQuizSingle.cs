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

namespace QuizFizyczny.UserControls
{
    public partial class UcQuizSingle : UserControl
    {
        List<int> listOidPytan = null;
        int liczbaPytan = 0;
        int aktualnyNumerPytania = 0;
        List<RadioButton> listRB;
        Pytania aktualnePytanieObj;
        int lacznaLiczbaPunktow = 0;
        Stopwatch czasOdpowiedzi = new Stopwatch();
        public UcQuizSingle(List<int> oidPytania)
        {
            InitializeComponent();
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
                    MessageBox.Show("Quiz zakończony", "Koniec");
                    //Liczba punktów: .... Zająłeś ... miejsce.
                    //this.Close();
                    //czasOdpowiedzi.Reset();
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
                        return true;                
            }
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

        private void bttnZakoncz_Click(object sender, EventArgs e)
        {

        }
    }
}
