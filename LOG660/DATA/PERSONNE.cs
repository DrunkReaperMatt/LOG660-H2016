//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LOG660.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSONNE
    {
        public PERSONNE()
        {
            this.ACTEURFILMs = new HashSet<ACTEURFILM>();
            this.FILMs = new HashSet<FILM>();
            this.FILMs1 = new HashSet<FILM>();
        }
    
        public decimal IDPERSONNE { get; set; }
        public string NOM { get; set; }
        public Nullable<System.DateTime> DATENAISSANCE { get; set; }
        public string LIEUNAISSANCE { get; set; }
        public decimal IDBIOGRAPHIE { get; set; }
        public string LIENPHOTO { get; set; }
    
        public virtual ACTEUR ACTEUR { get; set; }
        public virtual ICollection<ACTEURFILM> ACTEURFILMs { get; set; }
        public virtual BIOGRAPHIE BIOGRAPHIE { get; set; }
        public virtual ICollection<FILM> FILMs { get; set; }
        public virtual SCENARISTE SCENARISTE { get; set; }
        public virtual REALISATEUR REALISATEUR { get; set; }
        public virtual ICollection<FILM> FILMs1 { get; set; }
    }
}
