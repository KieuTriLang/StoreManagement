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
    class TableDAO : BaseDAO
    {
        public List<table> GetAll()
        {
            return db.tables.ToList();
        }
        public table GetSingleByID(string id)
        {
            return db.tables.Where(e => e.ID == id).FirstOrDefault();
        }
        public bool Add(table info)
        {
            try
            {
                db.tables.Add(info);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool Edit(table info)
        {
            try
            {
                var table = db.tables.Where(e => e.ID == info.ID).FirstOrDefault();
                table.ISEMPTY = info.ISEMPTY;
                table.BILL = info.BILL;
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
        public bool Delete(string id)
        {
            try
            {
                var info = GetSingleByID(id);
                db.tables.Remove(info);
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
    }
}
