using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppPB2_MBO.Models
{
    public class CartaoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CartaoContext() : base("name=CartaoContext")
        {
        }

        public System.Data.Entity.DbSet<WebAppPB2_MBO.Models.CartaoDeCredito> CartaoDeCreditoes { get; set; }
    }
}
