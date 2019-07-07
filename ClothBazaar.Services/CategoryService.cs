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
    public class CategoryService
    {
       

        public Category GetCategory(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Categories.Find(ID);
            }

        }
        public List<Category>GetCategories()
        {
            using (var context = new CBContext())
            {
                return context.Categories.ToList();
            }

        }
        public void SaveCategory(Category category)
        {
            using ( var context = new CBContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }

        }
        public void UpdateCategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Entry(category).State=EntityState.Modified;
                context.SaveChanges();
            }

        }
        public void DeleteCategory(int ID)
        {
            using (var context = new CBContext())
            {
                var category = context.Categories.Find(ID);
                // context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.Categories.Remove(category);
                context.SaveChanges();
            }

        }
    }

    
}
