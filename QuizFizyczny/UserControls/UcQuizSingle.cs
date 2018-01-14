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

namespace QuizFizyczny.UserControls
{
    public partial class UcQuizSingle : UserControl
    {
        List<int> listOidPytan = null;
        int liczbaPytan = 0;
        int aktualnyNumerPytania = 0;
        List<RadioButton> listRB;
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
            Pytania pytanieObj = ContextDb.contextDB.Pytania.Where(a => a.id == oidPytania).FirstOrDefault();
            textBoxPytanie.Text = pytanieObj.trescPytania;
            int rbcount = 0;
            foreach (var item in pytanieObj.Odpowiedzi)
            {
                listRB[rbcount].Text = item.odpowiedz;
                listRB[rbcount].Checked = false; //Odznaczenie poprzedniej odpowiedzi
                rbcount++;
            }
        }

        private void bttnOdpowiedz_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                //Policz punkty

                if (aktualnyNumerPytania + 1 < liczbaPytan)
                {
                    aktualnyNumerPytania++;
                    WyswietlPytanie(aktualnyNumerPytania);
                }
                else
                {
                    MessageBox.Show("Quiz zakończony", "Koniec");
                    //Liczba punktów: .... Zająłeś ... miejsce.
                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć odpowiedź", "Nie wybrano odpowiedzi");
            }
        }

        private void bttnZakoncz_Click(object sender, EventArgs e)
        {

        }
    }
}
