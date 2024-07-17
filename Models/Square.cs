using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritanceApp.Models
{
    internal class Square:Rectangle
    {
        public void CalculateArea()
        {
            Console.WriteLine("Calculate area of the square...");
        }
    }
}
