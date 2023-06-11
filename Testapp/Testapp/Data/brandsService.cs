using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Testapp.Models;
using Testapp.Data;

namespace Testapp.Data
{
   public class BrandsService
   {
         testdbContext db=new testdbContext();
		 
        //To Get all ProductionBrands details   
        public DbSet<ProductionBrands> GetAllProductionBrands()
        {
            try
            {
                return db.ProductionBrands;
            }
            catch
            {
                throw;
            }
        }
    }
   
}