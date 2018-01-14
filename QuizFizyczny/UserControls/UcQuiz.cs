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
    public partial class UcQuiz : UserControl
    { 
        int _counter = 0;
        List<Pytania> _obiektPytania;
        List<Odpowiedzi> _odpowiedzi;
        List<PoprawneOdpowiedzi> _poprawOdp;
        MenuStart _parent;

        Bitmap[] ikonyRund = new Bitmap[]
        {
            Properties.Resources.pyt1,
            Properties.Resources.pyt2,
            Properties.Resources.pyt3,
        };

        public UcQuiz(List<Pytania> pytania, List<Odpowiedzi> odpowiedzi, List<PoprawneOdpowiedzi> poprawOdp, MenuStart parent,  bool czyMultiplayer = false)
        {
            InitializeComponent();

            _obiektPytania = pytania;
            _odpowiedzi = odpowiedzi;
            _poprawOdp = poprawOdp;
            _parent = parent;
            przygotujRunde(_counter);

        }

        private void BtnDalej_Click(object sender, EventArgs e)
        {
            //sprawdzOdpowiedzi();
            if (_counter < 2)
            {
                przygotujRunde(++_counter);
            }
            else
                zakonczQuiz();
        }

        private void sprawdzOdpowiedzi()
        {
            throw new NotImplementedException();
        }

        private void przygotujRunde(int counter)
        {
            pBkonaRundy.Image = ikonyRund[counter];
            var pytanie = _obiektPytania[counter];

            TBPytanie.Text = pytanie.trescPytania;

            var odpowiedzi = _odpowiedzi.Where(x => x.id_pytanie == pytanie.id).ToList();

            rBtnOdp1.Text = odpowiedzi[0].odpowiedz;
            rBtnOdp2.Text = odpowiedzi[1].odpowiedz;
            rBtnOdp3.Text = odpowiedzi[2].odpowiedz;
            rBtnOdp4.Text = odpowiedzi[3].odpowiedz;

        }

        private void zakonczQuiz()
        {
            _parent.ustawPanelZTrybem(new UcMultiplayer(_parent));
        }
    }
}
