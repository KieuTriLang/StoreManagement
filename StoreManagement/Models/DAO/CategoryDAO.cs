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
    class CategoryDAO : BaseDAO
    {
        public class Cate
        {
            public string CateID { get; set; }
            public string CateText { get; set; }
        }
        public List<category> GetAll()
        {
            return db.categories.ToList();
        }
        public List<Cate> GetCategory()
        {
            return db.categories.Select(e=>new Cate { CateID = e.ID, CateText = e.CATENAME }).ToList();
        }
        public List<category> GetByKey(string keyword)
        {
            return db.categories.Where(e => e.ID == keyword || e.CATENAME == keyword).ToList();
        }
        public category GetSingleByID(string id)
        {
            return db.categories.Where(e => e.ID == id).FirstOrDefault();
        }
        public category GetSingleByName(string name)
        {
            return db.categories.Where(e => e.CATENAME == name).FirstOrDefault();
        }
        public string SetID()
        {
            string id = "Cate" + DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yy") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss"); ;
            return id;
        }
        public bool Add(category info)
        {
            try
            {
                info.CREATED_AT = DateTime.Now;
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
            catch (DbEntityValidationException e)
            {
                /*foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }*/
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
    }
}
