using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class BankController : ApiController
    {
        static int totalMoney = 1000;

        public static int giveMoney(int amount)
        {
            if (amount < 0)
                return -1;
            else if (amount > totalMoney)
                return -2;
            else
            {
                totalMoney -= amount;
                return totalMoney;
            }
        }

    }
}
