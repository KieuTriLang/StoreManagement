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
    class EmployeeDAO : BaseDAO
    {
        public List<employee> GetAll()
        {
            return db.employees.ToList();
        }
        public List<employee> GetByKey(string keyword)
        {
            return db.employees.Where(e => e.ID == keyword || e.FULLNAME == keyword || e.POSITON==keyword).ToList();
        }
        public employee GetSingleByID(string id)
        {
            return db.employees.Where(e => e.ID == id).FirstOrDefault();
        }
        public string SetID()
        {
            string id = "0000" + (db.employees.Count() + 1);
            return id;
        }
        public bool Add(employee info)
        {
            try
            {
                info.CREATED_AT = DateTime.Now;
                db.employees.Add(info);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool Edit(employee info)
        {
            try
            {
                var employee = db.employees.Where(e => e.ID == info.ID).FirstOrDefault();
                employee.FULLNAME = info.FULLNAME;
                employee.DOB = info.DOB;
                employee.ADR = info.ADR;
                employee.PHONENUME = info.PHONENUME;
                employee.POSITON = info.POSITON;
                employee.SALARY = info.SALARY;
                employee.FULLTIME = info.FULLTIME;
                employee.UPDATED_AT = DateTime.Now;
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
                //Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool Delete(string id)
        {
            try
            {
                var info = GetSingleByID(id);
                db.employees.Remove(info);
                db.SaveChanges();
            }
            catch(DbEntityValidationException e)
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
