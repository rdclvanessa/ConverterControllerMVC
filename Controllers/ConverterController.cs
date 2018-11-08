using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverterMVC.Models; 

using MathLibrary;

namespace UnitConverterMVC.Controllers
{
    public class ConverterController : Controller
    {
        public string Add(decimal left, decimal right)
        {
            // MyMath routines = new MyMath();
            // decimal value = routines.Add(left, right);
            return $"{left} plus {right} is: {MyMath.Add(left,right)}";
        }

         public string Ceiling(decimal number)
        {
            decimal result = Math.Ceiling(number);
            return $"The ceiling of {number} is {result}";
        }

        public string Floor(decimal number2)
        {
            return $"The floor of {number2} is {Math.Floor(number2)}";
        }

        public string Subtract(decimal up, decimal down)
        {
            return $"{up} minus {down} is {Decimal.Subtract(up, down)}";
        }

        public string Mulitply(decimal x, decimal y)
        {
            return $"{x} times {y} is {Decimal.Multiply(x, y)}";
        }

        public string Divide(decimal a, decimal b)
        {
            return $"{a} divided by {b} equals {Decimal.Divide(a, b)}";
        }

        public string Power(double north, double east)
        {
            return $"{north} raised to the power of {east} is {Math.Pow(north, east)}";
        }
    }
}
