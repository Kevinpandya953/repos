using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorBikeStoresapp.Models;

namespace BlazorBikeStoresapp.Data
{
   public class BrandService
   {
         BikeStoresContext db=new BikeStoresContext();
		 
        //To Get all Brand details   
        public DbSet<Brand> GetAllBrand()
        {
            try
            {
                return db.Brands;
            }
            catch
            {
                throw;
            }
        }
       // To Add new Data record
        public void AddBrand(Brand Data)
        {
            try
            {
                db.Brands.Add(Data);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar Data    
         public void UpdateBrand(Brand Data)
        {
            try
            {
                var data = db.Brands.Where(x => x.BrandId == Data.BrandId).SingleOrDefault();
                data.BrandId=Data.BrandId;
                data.BrandName=Data.BrandName;
                data.Products=Data.Products;
		   
			  
               db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record of a particular Data
         public void DeleteBrand(int value)
         {
           try
           {
             Brand data = db.Brands.Find(value);
            db.Brands.Remove(data);
            db.SaveChanges();
           }
           catch
           {
             throw;
            }
          }

        //Get the details of a particular Data    
        public Brand GetBrandData(int id)
        {
            try
            {
                Brand Data = db.Brands.Find(id);
                return Data;
            }
            catch
            {
                throw;
            }
        }
    }
   
}