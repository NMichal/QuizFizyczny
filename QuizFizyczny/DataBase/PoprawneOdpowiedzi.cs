//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuizFizyczny.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class PoprawneOdpowiedzi
    {
        public int id { get; set; }
        public int id_pytanie { get; set; }
        public int id_odpowiedzPytanie { get; set; }
    
        public virtual Odpowiedzi Odpowiedzi { get; set; }
        public virtual Pytania Pytania { get; set; }
    }
}
