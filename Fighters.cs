//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fighters
    {
        public int Fighter_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Weight_Id { get; set; }
        public int Promoution_Id { get; set; }
        public int Age { get; set; }
        public int Height_in_cm { get; set; }
        public int Reach_in_cm { get; set; }
        public string Degree { get; set; }
    
        public virtual Promoutions Promoutions { get; set; }
        public virtual Weight_Classes Weight_Classes { get; set; }
    }
}
