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
    
    public partial class RozgrywkaOdp
    {
        public int id { get; set; }
        public int idRozgrywki { get; set; }
        public int idodp1 { get; set; }
        public int idodp2 { get; set; }
        public int idodp3 { get; set; }
        public int iduzt { get; set; }
    
        public virtual Odpowiedzi Odpowiedzi { get; set; }
        public virtual Odpowiedzi Odpowiedzi1 { get; set; }
        public virtual Odpowiedzi Odpowiedzi2 { get; set; }
        public virtual Rozgrywka Rozgrywka { get; set; }
        public virtual Uzytkownicy Uzytkownicy { get; set; }
    }
}
