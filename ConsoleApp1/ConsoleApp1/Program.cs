using System;

namespace RaindropsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine(PlingPlangPlong(n));
        }

        public static string PlingPlangPlong(int x)
        {
            string output = "";

            if (x % 3 == 0)
            {
                output += "Pling";
            }

            if (x % 5 == 0)
            {
                output += "Plang";
            }

            if (x % 7 == 0)
            {
                output += "Plong";
            }

            if(output == "")
            {
                output += x;
            }

            return output;



        }
    }
}
