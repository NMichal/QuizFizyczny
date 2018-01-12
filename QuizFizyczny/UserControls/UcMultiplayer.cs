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
using QuizFizyczny.Class;

namespace QuizFizyczny.UserControls
{
    /// <summary>
    /// Klasa obsługująca menu multiplayer
    /// </summary>
    public partial class UcMultiplayer : UserControl
    {
        private MenuStart _parent;
        public UcMultiplayer(MenuStart menu)
        {
            InitializeComponent();
            _parent = menu;
        }

        private void BtnPlayMulti_Click(object sender, EventArgs e)
        {
            wyszukajIDolacz();
        }

        /// <summary>
        /// Tworzy nową rozgrywkę
        /// </summary>
        private void stworzNowaRozgrywke()
        {
            Rozgrywka nowaGra = new Rozgrywka();
            var pytania = ContextDb.contextDB.Pytania.ToList();
            List<int> pytaniaId = new List<int>();
            Random generator = new Random();
            
            while(pytaniaId.Count != 3)
            {
                int liczba = generator.Next(1, pytania.Count);
                if (!pytaniaId.Contains(liczba))
                    pytaniaId.Add(liczba);
            }

            List<Pytania> obiektPytania = ContextDb.contextDB.Pytania.Where(x => pytaniaId.Contains(x.id)).ToList();
            List<Odpowiedzi> odpowiedzi = ContextDb.contextDB.Odpowiedzi.Where(x => pytaniaId.Contains(x.id_pytanie)).ToList();
            List<PoprawneOdpowiedzi> poprawOdpo = ContextDb.contextDB.PoprawneOdpowiedzi.Where(x => pytaniaId.Contains(x.id_pytanie)).ToList();

            nowaGra.idUztk1 = ContextApp.IdUzytko;
            nowaGra.idPytanie1 = pytaniaId[0];
            nowaGra.idPytanie2 = pytaniaId[1];
            nowaGra.idPytanie3 = pytaniaId[2];

            ContextDb.contextDB.Rozgrywka.Add(nowaGra);
            ContextDb.contextDB.SaveChanges();
        }
        
        /// <summary>
        /// Wyszukuje wolną rozgrywkę i dołącza do niej
        /// </summary>
        private void wyszukajIDolacz()
        {
            var gra = ContextDb.contextDB.Rozgrywka.Where(x => x.idUztk2 == null && x.idUztk1 != ContextApp.IdUzytko).FirstOrDefault();

            if(gra != null)
            {
                //zapisanie id użytkownika jako drugiego
                gra.idUztk2 = ContextApp.IdUzytko;
                ContextDb.contextDB.SaveChanges();

                var pytaniaId = new List<int>()
                {
                    gra.idPytanie1,
                    gra.idPytanie2,
                    gra.idPytanie3
                };

                List<Pytania> obiektPytania = ContextDb.contextDB.Pytania.Where(x => pytaniaId.Contains(x.id)).ToList();
                List<Odpowiedzi> odpowiedzi = ContextDb.contextDB.Odpowiedzi.Where(x => pytaniaId.Contains(x.id_pytanie)).ToList();
                List<PoprawneOdpowiedzi> poprawOdpo = ContextDb.contextDB.PoprawneOdpowiedzi.Where(x => pytaniaId.Contains(x.id_pytanie)).ToList();
            }
            else
            {
                stworzNowaRozgrywke();
            }
        }
    }
}
