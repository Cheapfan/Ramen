using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ramen.Repository
{
    public class TransactionHeaderRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static List<Header> getHeaderByCustomerId(int id)
        {
            return (from x in db.Headers
                    where id == x.CustomerId
                    select x).ToList();
        }
    }
}