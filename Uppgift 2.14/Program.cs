using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj två tal med decimaler:");
            Console.Write("Tal 1: "); string strTal1 = Console.ReadLine();
            Console.Write("Tal 2: "); string strTal2 = Console.ReadLine();

            float floTal1 = float.Parse(strTal1);
            float floTal2 = float.Parse(strTal2);

            float produkt = floTal1 * floTal2;

            Console.WriteLine("Dessa två tal multiplicerade med varandra blir " + produkt);
        }
    }
}
