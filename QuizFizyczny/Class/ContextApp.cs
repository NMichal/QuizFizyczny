using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizFizyczny.Class
{
    /// <summary>
    /// Klasa statyczna. Posiada informacje o zalogowanym użytkowniku, zwłaszcza ważny jest jego id w bazie oraz login.
    /// </summary>
    public static class ContextApp
    {
        public static string LoginUzytko;
        public static int IdUzytko;
    }
}
