using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class Flipcoin
    {
        public static void Cointoss()
        {
            int Heads = 0;
            int Tails = 0;

            Console.WriteLine("Enter the number of times you want to flip the coin:");
            int NumberOfflips = Convert.ToInt32(Console.ReadLine());

            while (NumberOfflips <= 0)
            {
                Console.WriteLine("Invalid input, Please input a number greater than 0");
                Console.WriteLine("please enter again:");
                NumberOfflips = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < NumberOfflips; i++)
            {
                Random check = new Random();
                int headortail = check.Next(0, 2);

                if (headortail < 0.5)
                {
                    Heads++;
                }
                else
                {
                    Tails++;
                }
            }

            float HeadsPercent = (float)Heads * 100 / NumberOfflips;
            float TailsPercent = (float)Tails * 100 / NumberOfflips;

            Console.WriteLine(HeadsPercent + "% of the times the result was heads");
            Console.WriteLine(TailsPercent + "% of the times the result was tails");
        }
    }
}
