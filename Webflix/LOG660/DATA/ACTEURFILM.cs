
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LOG660.DATA
{

using System;
    using System.Collections.Generic;
    
public partial class ACTEURFILM
{

    public decimal IDPERSONNE { get; set; }

    public decimal IDFILM { get; set; }

    public string NOMPERSONNAGE { get; set; }



    public virtual PERSONNE PERSONNE { get; set; }

    public virtual FILM FILM { get; set; }

}

}
