
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
    
public partial class CLIENT
{

    public decimal IDUSAGER { get; set; }

    public string NUMEROCARTE { get; set; }

    public string TYPE { get; set; }

    public Nullable<byte> CCV { get; set; }

    public System.DateTime DATEEXPIRATIONCARTE { get; set; }

    public Nullable<decimal> IDFORFAIT { get; set; }



    public virtual USAGER USAGER { get; set; }

    public virtual FORFAIT FORFAIT { get; set; }

}

}
