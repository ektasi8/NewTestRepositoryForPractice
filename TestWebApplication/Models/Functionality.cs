using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    public class Functionality
    {
        public int Sum(int x,int y)
        {
            return x + y;
        }
        public int Multi(int x,int y)
        {
            return x * y;
        }

        public int Div(int num1,int num2)
        {
            return num1 - num2;
        }
    }
}