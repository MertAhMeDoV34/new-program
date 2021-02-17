using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи двоично число: ");
            string bin = Console.ReadLine();
            int dec = Convert.ToInt32(bin, 2);
            Console.WriteLine("Десетично:" +dec);
            Console.WriteLine("Двоично:" +bin);
        }
    }
}
