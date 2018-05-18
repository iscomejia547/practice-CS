using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type name: ");
            string name = Console.ReadLine();
            char rep;
            do
            {
                Console.Clear();
                Console.WriteLine("Hello " + name + " from C# .NET\nWant to play some game? (yea/nah)");
                string ans = Console.ReadLine();
                if (ans.Equals("yea"))
                {
                    Console.Clear();
                    date();
                    Random rnd = new Random();
                    int opt = rnd.Next(0, 4);
                    switch (opt)
                    {
                        case 1: doors(); break;
                        case 2: reverser(); break;
                        case 3: Console.WriteLine("Not supported yet"); break;
                        default: throw new Exception("Not right generated");
                    }
                }
                Console.WriteLine("Desea repetir los juegos? (S/N)");
                rep = Console.ReadLine().First();
            } while (rep == 's' || rep == 'S');
            Console.WriteLine("Goodbye user :)");
            Console.ReadLine();
        }
        static void doors()
        {
            Random rnd = new Random();
            string price = "You won ";
            int opt = rnd.Next(0, 4);
            switch (opt)
            {
                case 1: price += "a car"; break;
                case 2: price += "a house"; break;
                case 3: price += "nothing"; break;
                default: throw new Exception("Not right generated");
            }
            Console.WriteLine("Congratulations\n{0}", price);
        }
        static void reverser()
        {
            Console.Write("Reverse: ");
            string e = Console.ReadLine();
            char[] f = e.ToArray();
            Array.Reverse(f);
            foreach (char c in f)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
        public static void date()
        {
            DateTime d = DateTime.Now;
            Console.WriteLine(d.ToString());

        }
    }
}
