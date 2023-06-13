using Ramen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ramen.Handler
{
    public class TransactionHeaderHandler
    {
        public static List<Header> getHeaderByCustomerId(int id)
        {
            return TransactionHeaderRepository.getHeaderByCustomerId(id);
        }
    }
}