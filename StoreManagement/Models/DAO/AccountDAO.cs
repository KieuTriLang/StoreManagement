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
    class AccountDAO:BaseDAO
    {
        public List<account> GetAll()
        {
            return db.accounts.ToList();
        }
        public account GetAccount(string acc)
        {
            return db.accounts.Where(e => e.ACC == acc).FirstOrDefault();
        }
        public account GetSingleByID(string id)
        {
            return db.accounts.Where(e => e.EMPLOYEEID == id).FirstOrDefault();
        }
        public string SetID()
        {
            string id ="Acc"+ DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yy")+ DateTime.Now.ToString("HH")+ DateTime.Now.ToString("mm")+ DateTime.Now.ToString("ss");
            return id;
        }
        public bool Add(account info)
        {
            try
            {
                db.accounts.Add(info);
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
        public bool Edit(account info)
        {
            try
            {
                var account = GetSingleByID(info.EMPLOYEEID);
                account.EMPLOYEEID = info.EMPLOYEEID;
                account.ACC = info.ACC;
                account.PASS = info.PASS;
                account.ROLES = info.ROLES;
                account.UPDATED_AT = DateTime.Now;
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
                db.accounts.Remove(info);
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
