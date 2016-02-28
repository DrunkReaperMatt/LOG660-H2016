﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MovieEntityDataManager : DbContext
    {
        public MovieEntityDataManager()
            : base("name=MovieEntityDataManager")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACTEUR> ACTEURs { get; set; }
        public virtual DbSet<ACTEURFILM> ACTEURFILMs { get; set; }
        public virtual DbSet<ADRESSE> ADRESSEs { get; set; }
        public virtual DbSet<BIOGRAPHIE> BIOGRAPHIEs { get; set; }
        public virtual DbSet<CLIENT> CLIENTs { get; set; }
        public virtual DbSet<EMPLOYE> EMPLOYEs { get; set; }
        public virtual DbSet<EXEMPLAIRE> EXEMPLAIREs { get; set; }
        public virtual DbSet<FILM> FILMs { get; set; }
        public virtual DbSet<FORFAIT> FORFAITs { get; set; }
        public virtual DbSet<GENRE> GENREs { get; set; }
        public virtual DbSet<LIGNELOCATION> LIGNELOCATIONs { get; set; }
        public virtual DbSet<LOCATION> LOCATIONs { get; set; }
        public virtual DbSet<PAYSPRODUCTION> PAYSPRODUCTIONs { get; set; }
        public virtual DbSet<PERSONNE> PERSONNEs { get; set; }
        public virtual DbSet<REALISATEUR> REALISATEURs { get; set; }
        public virtual DbSet<RESUME> RESUMEs { get; set; }
        public virtual DbSet<SCENARISTE> SCENARISTEs { get; set; }
        public virtual DbSet<USAGER> USAGERs { get; set; }
    
        public virtual int PROC_ADDCLIENT(string nOM, string pRENOM, string cOURRIEL, string tELEPHONE, Nullable<decimal> nOCIVIC, string rUE, string aPPT, string vILLE, string zIP, string pROVINCE, string pAYS, string tYPEC, Nullable<decimal> nUMEROCARTE, Nullable<System.DateTime> dATEEXPIRATIONCARTE, Nullable<decimal> cCV, Nullable<System.DateTime> dATENAISSANCE, string mOTPASSE)
        {
            var nOMParameter = nOM != null ?
                new ObjectParameter("NOM", nOM) :
                new ObjectParameter("NOM", typeof(string));
    
            var pRENOMParameter = pRENOM != null ?
                new ObjectParameter("PRENOM", pRENOM) :
                new ObjectParameter("PRENOM", typeof(string));
    
            var cOURRIELParameter = cOURRIEL != null ?
                new ObjectParameter("COURRIEL", cOURRIEL) :
                new ObjectParameter("COURRIEL", typeof(string));
    
            var tELEPHONEParameter = tELEPHONE != null ?
                new ObjectParameter("TELEPHONE", tELEPHONE) :
                new ObjectParameter("TELEPHONE", typeof(string));
    
            var nOCIVICParameter = nOCIVIC.HasValue ?
                new ObjectParameter("NOCIVIC", nOCIVIC) :
                new ObjectParameter("NOCIVIC", typeof(decimal));
    
            var rUEParameter = rUE != null ?
                new ObjectParameter("RUE", rUE) :
                new ObjectParameter("RUE", typeof(string));
    
            var aPPTParameter = aPPT != null ?
                new ObjectParameter("APPT", aPPT) :
                new ObjectParameter("APPT", typeof(string));
    
            var vILLEParameter = vILLE != null ?
                new ObjectParameter("VILLE", vILLE) :
                new ObjectParameter("VILLE", typeof(string));
    
            var zIPParameter = zIP != null ?
                new ObjectParameter("ZIP", zIP) :
                new ObjectParameter("ZIP", typeof(string));
    
            var pROVINCEParameter = pROVINCE != null ?
                new ObjectParameter("PROVINCE", pROVINCE) :
                new ObjectParameter("PROVINCE", typeof(string));
    
            var pAYSParameter = pAYS != null ?
                new ObjectParameter("PAYS", pAYS) :
                new ObjectParameter("PAYS", typeof(string));
    
            var tYPECParameter = tYPEC != null ?
                new ObjectParameter("TYPEC", tYPEC) :
                new ObjectParameter("TYPEC", typeof(string));
    
            var nUMEROCARTEParameter = nUMEROCARTE.HasValue ?
                new ObjectParameter("NUMEROCARTE", nUMEROCARTE) :
                new ObjectParameter("NUMEROCARTE", typeof(decimal));
    
            var dATEEXPIRATIONCARTEParameter = dATEEXPIRATIONCARTE.HasValue ?
                new ObjectParameter("DATEEXPIRATIONCARTE", dATEEXPIRATIONCARTE) :
                new ObjectParameter("DATEEXPIRATIONCARTE", typeof(System.DateTime));
    
            var cCVParameter = cCV.HasValue ?
                new ObjectParameter("CCV", cCV) :
                new ObjectParameter("CCV", typeof(decimal));
    
            var dATENAISSANCEParameter = dATENAISSANCE.HasValue ?
                new ObjectParameter("DATENAISSANCE", dATENAISSANCE) :
                new ObjectParameter("DATENAISSANCE", typeof(System.DateTime));
    
            var mOTPASSEParameter = mOTPASSE != null ?
                new ObjectParameter("MOTPASSE", mOTPASSE) :
                new ObjectParameter("MOTPASSE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_ADDCLIENT", nOMParameter, pRENOMParameter, cOURRIELParameter, tELEPHONEParameter, nOCIVICParameter, rUEParameter, aPPTParameter, vILLEParameter, zIPParameter, pROVINCEParameter, pAYSParameter, tYPECParameter, nUMEROCARTEParameter, dATEEXPIRATIONCARTEParameter, cCVParameter, dATENAISSANCEParameter, mOTPASSEParameter);
        }
    
        public virtual int PROC_RENTMOVIE(Nullable<decimal> iDUSER, Nullable<decimal> iDMOVIE, Nullable<decimal> iDEXEMPLAIRE)
        {
            var iDUSERParameter = iDUSER.HasValue ?
                new ObjectParameter("IDUSER", iDUSER) :
                new ObjectParameter("IDUSER", typeof(decimal));
    
            var iDMOVIEParameter = iDMOVIE.HasValue ?
                new ObjectParameter("IDMOVIE", iDMOVIE) :
                new ObjectParameter("IDMOVIE", typeof(decimal));
    
            var iDEXEMPLAIREParameter = iDEXEMPLAIRE.HasValue ?
                new ObjectParameter("IDEXEMPLAIRE", iDEXEMPLAIRE) :
                new ObjectParameter("IDEXEMPLAIRE", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_RENTMOVIE", iDUSERParameter, iDMOVIEParameter, iDEXEMPLAIREParameter);
        }
    
        public virtual int PROC_RENTMOVIE2(Nullable<decimal> iDUSER, Nullable<decimal> iDMOVIE, Nullable<decimal> iDMOVIEEXEMPLAIRE)
        {
            var iDUSERParameter = iDUSER.HasValue ?
                new ObjectParameter("IDUSER", iDUSER) :
                new ObjectParameter("IDUSER", typeof(decimal));
    
            var iDMOVIEParameter = iDMOVIE.HasValue ?
                new ObjectParameter("IDMOVIE", iDMOVIE) :
                new ObjectParameter("IDMOVIE", typeof(decimal));
    
            var iDMOVIEEXEMPLAIREParameter = iDMOVIEEXEMPLAIRE.HasValue ?
                new ObjectParameter("IDMOVIEEXEMPLAIRE", iDMOVIEEXEMPLAIRE) :
                new ObjectParameter("IDMOVIEEXEMPLAIRE", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_RENTMOVIE2", iDUSERParameter, iDMOVIEParameter, iDMOVIEEXEMPLAIREParameter);
        }
    }
}
