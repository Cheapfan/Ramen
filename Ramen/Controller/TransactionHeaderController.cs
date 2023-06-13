using Ramen.Handler;
using Ramen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ramen.Controller
{
    public class TransactionHeaderController
    {
        public static void insertHeader(List<ItemDetail> items, int customerId, int staffId, DateTime date)
        {

        }

        public static List<Header> getHeaderByCustomerId(int id)
        {
            return TransactionHeaderHandler.getHeaderByCustomerId(id);
        }
    }
}