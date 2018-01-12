using QuizFizyczny.Class;
using QuizFizyczny.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFizyczny.Forms
{
    public partial class FrmLoginRegister : Form
    {
       // Thread splash;
        public FrmLoginRegister()
        {
            InitializeComponent();
        }

        #region REJESTRACJA
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (walidujRejestracje())
            {
                if (sprobujZarejestrowac(TbLoginRegister.Text, TbHasloRegister.Text))
                {
                    MessageBox.Show("Rejestracja przebiegła pomyślnie!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TbLoginRegister.Text = TbHasloRegister.Text = TbPowtozHaslo.Text = string.Empty;
                    tabControl1.SelectedTab = TPLogin;
                }
            }
            else
                MessageBox.Show("Login zajęty lub hasła nie są takie same.", "Błąd w formularzu!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        /// <summary>
        /// Metoda probujaca zarejestrowac uzytkownika
        /// </summary>
        /// <param name="login">login uzytkownika</param>
        /// <param name="haslo">haslo uzytkownika</param>
        /// <returns>True jeżeli uda się zarejestrować w pzeciwnym przypadku False</returns>
        private bool sprobujZarejestrowac(string login, string haslo)
        {
            try
            {
                var nowyUzytkownik = new Uzytkownicy()
                {
                    login = login,
                    haslo = haslo
                };

                ContextDb.contextDB.Uzytkownicy.Add(nowyUzytkownik);
                ContextDb.contextDB.SaveChanges();

                return true;
            }
            catch(Exception exp)
            {
                return false;
            }
        }

        /// <summary>
        /// Metoda walidująca parametry podane przez użytkownika
        /// </summary>
        /// <returns></returns>
        private bool walidujRejestracje()
        {
            return walidujLogin(TbLoginRegister.Text) && walidujHaslo(TbHasloRegister.Text, TbPowtozHaslo.Text);
        }

        /// <summary>
        /// Metoda walidująca hasła podane przez użytkownika. Czy oba hasła są takie same.
        /// </summary>
        /// <param name="haslo">Hasło uzytkownika</param>
        /// <param name="powtorzHaslo">Powtórzone hasło użytkownika</param>
        /// <returns>True jeżeli hasła są takie same w przeciwnym wypadku False</returns>
        private bool walidujHaslo(string haslo, string powtorzHaslo)
        {
            if (!string.IsNullOrWhiteSpace(haslo) && !string.IsNullOrWhiteSpace(powtorzHaslo))
                return haslo.Equals(powtorzHaslo);

            return false;
                    
        }

        /// <summary>
        /// Metoda sprawdzająca czy nie istnieje podany login w bazie.
        /// </summary>
        /// <param name="login">Login użytkownika</param>
        /// <returns>True jeżeli login nie jest zajęty, w przeciwnym przypadku False</returns>
        private bool walidujLogin(string login)
        {
            var list = ContextDb.contextDB.Uzytkownicy.Where(x => x.login == login).ToList();

            return list.Count == 0;
        }
        #endregion

        #region LOGOWANIE
        private void BtnLogin_Click(object sender, EventArgs e)
        {
           // wlaczLadowanie();
            if (walidujLogowanie(TbLogin.Text, TbHaslo.Text))
            {
                //wylaczLadowanie();
                var form = new MenuStart();
                this.Hide();
                form.Show();
            }
            else
            {
                //wylaczLadowanie();
                MessageBox.Show("Nie porwany login bądź hasło!", "Błąd przy logowaniu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                
        }

        /// <summary>
        /// Metoda sprawdzająca czy użytkownik o podanym loginie oraz haśle istnieje w bazie.
        /// Jeżeli istnieje dodaje login oraz id użytkownika do kontekstu aplikacji.
        /// </summary>
        /// <param name="login">Login uzytkownika</param>
        /// <param name="haslo">Hasło użytkownika</param>
        /// <returns>True, jeżeli podany login oraz hasła zgadzają się w przeciwnym pzypadku False</returns>
        private bool walidujLogowanie(string login, string haslo)
        {
            var uzytkownik = ContextDb.contextDB.Uzytkownicy.Where(x => x.login == login && x.haslo == haslo).FirstOrDefault();
            if(uzytkownik != null)
            {
                ContextApp.IdUzytko = uzytkownik.id;
                ContextApp.LoginUzytko = uzytkownik.login;

                return true;
            }

            return false;
        }

        #endregion

        //na razie nie dziala musze ogarnac, na watku przy ponownym uruchomieniu sie wywala a szkoda bo fajny efekt przy ładowaniu
        //#region SPLASHSCREEN
        ///// <summary>
        ///// Wylacza splash screen
        ///// </summary>
        //private void wylaczLadowanie()
        //{
        //    splash.Close();
        //}

        ///// <summary>
        ///// Wlacza splash screen
        ///// </summary>
        //private void wlaczLadowanie()
        //{
        //    splash = new ThreadStart()
        //    splash.Show();
        //}
        //#endregion
    }
}
