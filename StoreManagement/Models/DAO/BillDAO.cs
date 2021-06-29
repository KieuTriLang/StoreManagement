using Newtonsoft.Json;
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
    class BillDAO : BaseDAO
    {
        public List<bill> GetAll()
        {
            return db.bills.ToList();
        }
        public List<bill> GetByKey(string keyword)
        {
            return db.bills.Where(e => e.PAYERNAME == keyword).ToList();
        }
        public bill GetSingleByID(string id)
        {
            return db.bills.Where(e => e.ID == id).FirstOrDefault();
        }
        public string GetOrdersPaid(DateTime day)
        {
            if(db.bills.Where(e => e.PAID == true && e.CREATED_AT.Value.Day == day.Day && e.CREATED_AT.Value.Month == day.Month && e.CREATED_AT.Value.Year == day.Year).Count() == 0)
            {
                return "---";
            }
            else
            {
                return db.bills.Where(e => e.PAID == true && e.CREATED_AT.Value.Day == day.Day && e.CREATED_AT.Value.Month == day.Month && e.CREATED_AT.Value.Year == day.Year).Count().ToString();
            }
        }
        public string GetProdPaid(DateTime day)
        {
            if (db.bills.Where(e => e.PAID == true && e.CREATED_AT.Value.Day == day.Day && e.CREATED_AT.Value.Month == day.Month && e.CREATED_AT.Value.Year == day.Year).Count() == 0)
            {
                return "---";
            }
            else
            {
                List<bill> list = db.bills.Where(e => e.PAID == true && e.CREATED_AT.Value.Day == day.Day && e.CREATED_AT.Value.Month == day.Month && e.CREATED_AT.Value.Year == day.Year).ToList();
                double quantity = 0;
                foreach(bill b in list)
                {
                    foreach(ProductOrder productOrder in JsonConvert.DeserializeObject<List<ProductOrder>>(b.BILL1))
                    {
                        quantity += productOrder.Quantity;
                    }
                }
                return "" + quantity;
            }
        }
        public string GetIncomePaid(DateTime day)
        {
            if (db.bills.Where(e => e.PAID == true && e.CREATED_AT.Value.Day == day.Day && e.CREATED_AT.Value.Month == day.Month && e.CREATED_AT.Value.Year == day.Year).Count() == 0)
            {
                return "---";
            }
            else
            {
                List<bill> list = db.bills.Where(e => e.PAID == true && e.CREATED_AT.Value.Day == day.Day && e.CREATED_AT.Value.Month == day.Month && e.CREATED_AT.Value.Year == day.Year).ToList();
                double income = 0;
                foreach (bill b in list)
                {
                    foreach (ProductOrder productOrder in JsonConvert.DeserializeObject<List<ProductOrder>>(b.BILL1))
                    {
                        income += productOrder.Price * productOrder.Quantity;
                    }
                }
                return "$" + income;
            }
        }
        public string SetID()
        {
            string id = "Bill" + DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yy") + DateTime.Now.ToString("HH") + DateTime.Now.ToString("mm") + DateTime.Now.ToString("ss"); ;
            return id;
        }
        public bool Add(bill info)
        {
            try
            {
                info.CREATED_AT = DateTime.Now;
                db.bills.Add(info);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public bool Edit(bill info)
        {
            try
            {
                var bill = db.bills.Where(e => e.ID == info.ID).FirstOrDefault();
                bill.ID = info.ID;
                bill.PAYERNAME = info.PAYERNAME;
                bill.BILL1 = info.BILL1;
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
                db.bills.Remove(info);
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
