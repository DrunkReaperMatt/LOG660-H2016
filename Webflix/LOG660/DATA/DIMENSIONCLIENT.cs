
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
    
public partial class DIMENSIONCLIENT
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DIMENSIONCLIENT()
    {

        this.FAITLOCATIONFILMCLIENTINSTANTs = new HashSet<FAITLOCATIONFILMCLIENTINSTANT>();

    }


    public decimal IDCLIENT { get; set; }

    public string NOM { get; set; }

    public decimal GROUPEAGE { get; set; }

    public System.DateTime ANCIENNETE { get; set; }

    public string CODEPOSTAL { get; set; }

    public string VILLE { get; set; }

    public string PROVINCE { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<FAITLOCATIONFILMCLIENTINSTANT> FAITLOCATIONFILMCLIENTINSTANTs { get; set; }

}

}