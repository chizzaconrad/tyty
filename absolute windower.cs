using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const double MaxWidth = 5.0;
            const double MinWidth = 0.5;
            const double MaxHeight = 3.0;
            const double MinHeight = 0.75;

            Console.WriteLine("give me the width of the window");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Now the height");
            double height = double.Parse(Console.ReadLine());

            if (width > MaxWidth)
            {
                Console.WriteLine("too large mate ill set it to the biggest");
                width = MaxWidth;
            }
            if (width < MinWidth)
            {
                Console.WriteLine("too small ill put it as the smallest");
                width = MinWidth;
            }


            if (height > MaxHeight)
            {
                Console.WriteLine("wayyy to tall, ill put it as the tallest i can");
                height = MaxHeight;
            }
            if (height < MinHeight)
            {
                Console.WriteLine("bit on the shorter side so i will just put it as the smallest i can");
                height = MinHeight;
            }

            double woodLength = width * height * 2 * 3.25;
            double glassArea = width * height * 2;

            Console.WriteLine($"you will need this much wood: {woodLength}");
            Console.WriteLine($"you will need this much glass: {glassArea}");
            Console.ReadLine();
        }
    }
}
