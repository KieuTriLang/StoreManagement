using StoreManagement.DAO.BaseDAO;
using StoreManagement.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Models.DAO
{
    class CategoryDAO : BaseDAO
    {
        public List<category> GetAll()
        {
            return db.categories.ToList();
        }
        public List<category> GetByKey(string keyword)
        {
            return db.categories.Where(e => e.ID == keyword || e.CATENAME == keyword).ToList();
        }
        public category GetSingleByID(string id)
        {
            return db.categories.Where(e => e.ID == id).FirstOrDefault();
        }
        public string SetID()
        {
            string id = "0000" + (db.categories.Count() + 1);
            return id;
        }
        public bool Add(category info)
        {
            try
            {
                db.categories.Add(info);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool Edit(category info)
        {
            try
            {
                var category = db.categories.Where(e => e.ID == info.ID).FirstOrDefault();
                category.CATENAME = info.CATENAME;
                category.ILLUSTRATION = info.ILLUSTRATION;
                category.UPDATED_AT = DateTime.Now;
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
                db.categories.Remove(info);
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
