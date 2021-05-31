using System;

namespace ConsoleApp1_peter_3105
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int pm2_5 = 22;
            Console.WriteLine("pm2,5 --> " + pm2_5);
            Console.WriteLine( $"default(DateTime) = {default(DateTime)}");


            string[] names;
            names = new string[4];
            names[1] = "Mirek";
            names[0] = "Tolek";
            names[3] = "Milek";
           Console.WriteLine(names[1]);
            Console.WriteLine(names[0]);

            for (int i = 0; i <names.Length ;i++)
            {
                Console.WriteLine(names[i]);

            };
        }
    }
}
