using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class CalController : ApiController
    {

        public static double summation(double a, double b)
        {
            return a + b;
        }

        public static double subtraction(double a, double b)
        {
            return a - b;
        }

        public static double multiplication(double a, double b)
        {
            return a * b;
        }

        public static double division(double a, double b)
        {
            return a / b;
        }


    }
}