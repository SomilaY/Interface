using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype03_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetArea()); // Output: 50
            Console.WriteLine(rect.GetPerimeter()); // Output: 30
            Console.ReadLine();
        }
    }
}
