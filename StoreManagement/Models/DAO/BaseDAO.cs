using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DAO.BaseDAO
{
    class BaseDAO 
    {
        protected Models.EF.LLAKCoffeeEntities db;
        public BaseDAO()
        {
            db = new Models.EF.LLAKCoffeeEntities();
        }
    }
}
