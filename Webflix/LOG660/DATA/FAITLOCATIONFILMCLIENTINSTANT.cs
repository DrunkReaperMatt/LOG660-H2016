
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
    
public partial class FAITLOCATIONFILMCLIENTINSTANT
{

    public decimal IDCLIENT { get; set; }

    public decimal IDTEMPS { get; set; }

    public decimal IDFILM { get; set; }



    public virtual DIMENSIONCLIENT DIMENSIONCLIENT { get; set; }

    public virtual DIMENSIONFILM DIMENSIONFILM { get; set; }

    public virtual DIMENSIONTEMP DIMENSIONTEMP { get; set; }

}

}