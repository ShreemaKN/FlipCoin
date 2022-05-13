using System;

namespace BasicPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for a particular problem");
            Console.WriteLine("1 for Flip coin and finding percentage of heads and tails");

            int Problem = Convert.ToInt32(Console.ReadLine());
            Program basicprogram = new Program();
            switch (Problem)
            {
                case 1:
                    Flipcoin coin = new Flipcoin();
                    Flipcoin.Cointoss();
                    break;
            }
        }
    }
}