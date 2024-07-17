using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilevelInheritanceApp.Models
{
    internal class Shapes
    {
        public void Draw()
        {
            Console.WriteLine("Draw a shape...");
        }
        public void Move()
        {
            Console.WriteLine("Move a shape...");
        }
    }
}
