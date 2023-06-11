using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BikeStoresapp1.Models;
using BikeStoresapp1.Data;

namespace BikeStoresapp1.Data
{
   public class BrandsService
   {
         BikeStoresContext db=new BikeStoresContext();
		 
        //To Get all brands details   
        public DbSet<brands> GetAllbrands()
        {
            try
            {
                return db.brands;
            }
            catch
            {
                throw;
            }
        }
    }
   
}