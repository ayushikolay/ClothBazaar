using ClothBazaar.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ClothBazaar.Database;
using System.Web.Configuration;


namespace ClothBazaar.Services
{
    public class ProductService
    {
       

        public Product GetProduct(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Products.Find(ID);
            }

        }
        public List<Product>GetProducts()
        {
            using (var context = new CBContext())
            {
                return context.Products.ToList();
            }

        }
        public void SaveProduct(Product product)
        {
            using ( var context = new CBContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }

        }
        public void UpdateProduct(Product product)
        {
            using (var context = new CBContext())
            {
                context.Entry(product).State=EntityState.Modified;
                context.SaveChanges();
            }

        }
        public void DeleteProduct(int ID)
        {
            using (var context = new CBContext())
            {
                var product = context.Products.Find(ID);
                // context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.Products.Remove(product);
                context.SaveChanges();
            }

        }
    }

    
}
