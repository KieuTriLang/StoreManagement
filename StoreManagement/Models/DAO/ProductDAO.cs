using StoreManagement.DAO.BaseDAO;
using StoreManagement.Models.EF;
using System;
using System.Collections.Generic;
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
            return db.products.Where(e => e.ID == keyword || e.NAMEPROD == keyword).ToList();
        }
        public product GetSingleByID(string id)
        {
            return db.products.Where(e => e.ID == id).FirstOrDefault();
        }
        public string SetID()
        {
            string id = "0000" + (db.products.Count()+1);
            return id;
        }
        public bool Add(product info)
        {
            try
            {
                db.products.Add(info);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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
