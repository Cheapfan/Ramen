using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ramen.Repository
{
    public class TransactionDetailRepository
    {
        public static LocalDatabaseEntities db = new LocalDatabaseEntities();
        public static List<Detail> getDetailByHeaderId(int id)
        {
            return (from x in db.Details
                    where id == x.HeaderId
                    select x).ToList();
        }
    }
}