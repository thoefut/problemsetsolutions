/* Change Return Program 
 * The user enters a cost and then the amount of money given. The program will figure out the change and the number of quarters, dimes, nickels, 
 * pennies needed for the change.
 * 
 * Input: decimal price and decimal money given
 * Output: change in quarters, dimes, nickels and pennies
 */
using System;

namespace Change_Calculator
{
    static class Program
    {
        static void Main()
        {
            Console.WriteLine("To calculate change enter the price in dollars");
            string price = Console.ReadLine();
            Console.WriteLine("Enter the sum you provide in dollars");
            string money = Console.ReadLine();
            decimal change = decimal.Parse(money) - decimal.Parse(price);
            if (change < 0)
            {
                Console.WriteLine("Not enough money provided!");
            }
            else
            {
                Console.WriteLine("Change is ${0}. {1}", change, ChangeCalculator.CalculateChange(change));
            }
        }
    }
    public static class ChangeCalculator
    {
        private enum CoinName : int { Quarter, Dime, Nickel, Penny };
        static readonly decimal[] values = { 0.25m, 0.10m, 0.05m, 0.01m };
        static readonly decimal[] coins = { 0, 0, 0, 0 };
        
        /// <summary>
        /// Calculates change in integer coins from provided decimal change and gives back formatted string to be printed
        /// </summary>
        /// <param name="change">
        /// Decimal number to calculate and format string from. 
        /// Negative number would result in no change given back
        /// </param>
        /// <returns>
        /// Formatted string containing number of each coin used to give change
        /// </returns>
        public static string CalculateChange(decimal change)
        {
            if (change <= 0)
            { return "No change is needed"; }
            for (int coin = 0; coin < coins.Length; coin++)
            {
                while (change / values[coin] >= 1)
                {
                    coins[coin]++;
                    change -= values[coin];
                }
            }
            string str = "It would require you " + coins[(int)CoinName.Quarter].ToString() + " quarters " + coins[(int)CoinName.Dime].ToString() + " dimes " + coins[(int)CoinName.Nickel].ToString() + " nickels " + "and " + coins[(int)CoinName.Penny].ToString() + " pennies";
            return str;
        }
    }
}
