//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GWS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.CarMakes = new HashSet<CarMake>();
            this.tblLogins = new HashSet<tblLogin>();
        }
    
        public int Country_Id { get; set; }
        public string CountryName { get; set; }
    
        public virtual ICollection<CarMake> CarMakes { get; set; }
        public virtual ICollection<tblLogin> tblLogins { get; set; }
    }
}