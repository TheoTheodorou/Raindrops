using System;

namespace RaindropsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            bool success = Int32.TryParse(Console.ReadLine(),out int n);

            if (success)
            {
                Console.WriteLine(PlingPlangPlong(n));
            }

            else
            {
                Console.WriteLine("Please enter a valid number");
            }

        }

        /// <summary>
        /// Method to convert a number to a string, depending on the number's factors
        /// </summary>
        /// <param name="x"></param>
        /// <returns>
        /// Output string
        /// </returns>
        public static string PlingPlangPlong(int x)
        {
            // Empty string
            string output = "";

            // If the number has a factor of 3, output 'Pling'
            if (x % 3 == 0)
            {
                output += "Pling";
            }

            // If the number has a factor of 5, output 'Plang'
            if (x % 5 == 0)
            {
                output += "Plang";
            }

            // If the number has a factor of 7, output 'Plong'
            if (x % 7 == 0)
            {
                output += "Plong";
            }

            // If the number does not have any of the above as a factor simply return the numbers digits 
            if (output == "")
            {
                output += x;
            }

            return output;
        }
    }
}
