using Ramen.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ramen.Controller
{
    public class TransactionDetailController
    {
        public static List<Detail> getDetailByHeaderId(int id)
        {
            return TransactionDetailHandler.getDetailByHeaderId(id);
        }
    }
}