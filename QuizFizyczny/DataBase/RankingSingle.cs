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
    
    public partial class RankingSingle
    {
        public int id { get; set; }
        public int idGracza { get; set; }
        public int punkty { get; set; }
    
        public virtual Uzytkownicy Uzytkownicy { get; set; }
    }
}