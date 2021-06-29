using StoreManagement.DAO.BaseDAO;
using StoreManagement.Models.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models.DAO
{
    class ProductDAO : BaseDAO
    {
        public List<product> GetAll()
        {
            return db.products.ToList();
        }
        public List<product> GetByKey(string keyword)
        {
            return db.products.Where(e => e.ID == keyword || e.NAMEPROD == keyword || e.CATEGORYID == keyword).ToList();
        }
        public product GetSingleByID(string id)
        {
            return db.products.Where(e => e.ID == id).FirstOrDefault();
        }
        public product GetSingleByName(string name)
        {
            return db.products.Where(e => e.NAMEPROD == name).FirstOrDefault();
        }
        public string SetID()
        {
            string id = "Prod" + DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yy") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss"); ;
            return id;
        }
        public bool Add(product info)
        {
            try
            {
                db.products.Add(info);
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                return false;
            }
            return true;
        }
        public bool Edit(product info)
        {
            try
            {
                var product = db.products.Where(e => e.ID == info.ID).FirstOrDefault();
                product.NAMEPROD = info.NAMEPROD;
                product.CATEGORYID = info.CATEGORYID;
                product.PRICE = info.PRICE;
                product.BOUGHT = info.BOUGHT;
                product.SOLD = info.SOLD;
                product.UPDATED_AT = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool Delete(string id)
        {
            try
            {
                var info = GetSingleByID(id);
                db.products.Remove(info);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
    }
}
