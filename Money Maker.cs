using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Please enter the amount you would like to convert");
            string amount = Console.ReadLine();
            double amount2 = Convert.ToDouble(amount);

            Console.WriteLine($"{amount2} is equal to:");

            int goldVal = 10;
            int silverVal = 5;

            double goldCoin = Math.Floor(amount2 / goldVal);
            double remainder = amount2 % goldVal;

            Console.WriteLine(goldCoin);
            Console.WriteLine(remainder);


            double silverCoin = Math.Floor(remainder / silverVal);
            Console.WriteLine(silverCoin);
            Console.WriteLine(remainder);


            Console.WriteLine($"Gold Coins = {goldCoin}");
            Console.WriteLine($"Silver Coins = {silverCoin}");
            Console.WriteLine($"Bronze Coins = {remainder}");


        }
    }
}
