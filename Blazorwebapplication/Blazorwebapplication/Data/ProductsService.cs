using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blazorwebapplication.Models;
using Blazorwebapplication.Data;

namespace Blazorwebapplication.Data
{
   public class ProductsService
   {
        readonly BikeStoresContext db=new BikeStoresContext();
		 
        //To Get all Product details   
        public DbSet<Product> GetAllProduct()
        {
            try
            {
                return db.Products;
            }
            catch
            {
                throw;
            }
        }
    }
   
}