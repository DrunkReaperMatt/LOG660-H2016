
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
    
public partial class FORFAIT
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public FORFAIT()
    {

        this.CLIENTs = new HashSet<CLIENT>();

    }


    public decimal IDFORFAIT { get; set; }

    public string NOM { get; set; }

    public decimal COUT { get; set; }

    public decimal LOCATIONMAX { get; set; }

    public decimal DUREEMAX { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<CLIENT> CLIENTs { get; set; }

}

}