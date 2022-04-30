﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class WebScrapingEntities : DbContext
    {
        public WebScrapingEntities()
            : base("name=WebScrapingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Item> Items { get; set; }
    
        public virtual int SP_ADD(string nAME, Nullable<decimal> pRICE, string lINK, Nullable<int> cONDITION, Nullable<int> sHOP, string iMAGE, Nullable<int> tYPE)
        {
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            var pRICEParameter = pRICE.HasValue ?
                new ObjectParameter("PRICE", pRICE) :
                new ObjectParameter("PRICE", typeof(decimal));
    
            var lINKParameter = lINK != null ?
                new ObjectParameter("LINK", lINK) :
                new ObjectParameter("LINK", typeof(string));
    
            var cONDITIONParameter = cONDITION.HasValue ?
                new ObjectParameter("CONDITION", cONDITION) :
                new ObjectParameter("CONDITION", typeof(int));
    
            var sHOPParameter = sHOP.HasValue ?
                new ObjectParameter("SHOP", sHOP) :
                new ObjectParameter("SHOP", typeof(int));
    
            var iMAGEParameter = iMAGE != null ?
                new ObjectParameter("IMAGE", iMAGE) :
                new ObjectParameter("IMAGE", typeof(string));
    
            var tYPEParameter = tYPE.HasValue ?
                new ObjectParameter("TYPE", tYPE) :
                new ObjectParameter("TYPE", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ADD", nAMEParameter, pRICEParameter, lINKParameter, cONDITIONParameter, sHOPParameter, iMAGEParameter, tYPEParameter);
        }
    
        public virtual ObjectResult<string> SP_GET_BLACK_LIST()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("SP_GET_BLACK_LIST");
        }
    
        public virtual ObjectResult<SP_GET_ONE_Result> SP_GET_ONE(string iD)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GET_ONE_Result>("SP_GET_ONE", iDParameter);
        }
    
        public virtual ObjectResult<SP_GetAllLinks_Result> SP_GetAllLinks()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetAllLinks_Result>("SP_GetAllLinks");
        }
    
        public virtual int SP_UPDATE_PRICE(Nullable<int> iD, Nullable<decimal> pRICE, Nullable<decimal> oLD_PRICE, Nullable<decimal> sAVNG, Nullable<decimal> sAVNG_PERCENT, string nAME)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var pRICEParameter = pRICE.HasValue ?
                new ObjectParameter("PRICE", pRICE) :
                new ObjectParameter("PRICE", typeof(decimal));
    
            var oLD_PRICEParameter = oLD_PRICE.HasValue ?
                new ObjectParameter("OLD_PRICE", oLD_PRICE) :
                new ObjectParameter("OLD_PRICE", typeof(decimal));
    
            var sAVNGParameter = sAVNG.HasValue ?
                new ObjectParameter("SAVNG", sAVNG) :
                new ObjectParameter("SAVNG", typeof(decimal));
    
            var sAVNG_PERCENTParameter = sAVNG_PERCENT.HasValue ?
                new ObjectParameter("SAVNG_PERCENT", sAVNG_PERCENT) :
                new ObjectParameter("SAVNG_PERCENT", typeof(decimal));
    
            var nAMEParameter = nAME != null ?
                new ObjectParameter("NAME", nAME) :
                new ObjectParameter("NAME", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_PRICE", iDParameter, pRICEParameter, oLD_PRICEParameter, sAVNGParameter, sAVNG_PERCENTParameter, nAMEParameter);
        }
    
        public virtual int SP_UPDATE_STATUS(Nullable<int> iD, Nullable<int> sTATUS)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var sTATUSParameter = sTATUS.HasValue ?
                new ObjectParameter("STATUS", sTATUS) :
                new ObjectParameter("STATUS", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UPDATE_STATUS", iDParameter, sTATUSParameter);
        }
    }
}
