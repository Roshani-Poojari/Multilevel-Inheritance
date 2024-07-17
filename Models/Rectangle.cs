using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritanceApp.Models
{
    internal class Rectangle:Shapes
    {
        public void Resize()
        {
            Console.WriteLine("Resize the rectangle...");
        }
    }
}
