using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizFizyczny.DataBase
{
    /// <summary>
    /// Singleton do połączenia z bazą danych.
    /// </summary>
    public class ContextDb
    {
        private static QuizFizEntities _instacja;
        
        public static QuizFizEntities contextDB
        {
            get
            {
                if (_instacja == null)
                    _instacja = new QuizFizEntities();

                return _instacja;
            }
        }
    }
}
