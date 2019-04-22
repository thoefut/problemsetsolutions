/* Coin Flip Simulation 
 * Write some code that simulates flipping a single coin however many times the user decides. The code should record the outcomes and count the number of tails and heads.
 * 
 * Input = User enters number of times he wants to flip a coin
 * Output = Programs prints flip statistics
 */

using System;

namespace Coin_Flip_Simulation
{
    class Program
    {
        static void Main()
        {
            Coinflipper flipper = new Coinflipper();
            Console.WriteLine("Enter number of times you would like to throw the coin");
            try
            {
                flipper.FlipAndStore(int.Parse(Console.ReadLine()));
                Console.WriteLine("Number of \"tails\" flips {0}", flipper.Tails);
                Console.WriteLine("Number of \"heads\" flips {0}", flipper.Heads);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Formatting error occured");
                Environment.Exit(-1);
            }
        }
    }
    public class Coinflipper
    {

        public int Tails { get; set; }
        public int Heads { get; set; }
        private static Random flipper;
        public Coinflipper()
        {
            flipper = new Random();
            Heads = 0;
            Tails = 0;
        }
        /// <summary>
        /// Flips the coin and stores the result in this object
        /// </summary>
        /// <returns>
        /// true if tails
        /// false if heads
        /// </returns>
        public bool FlipAndStore()
        {
            bool flip = FlipCoin();
            if (flip == false)
            { this.Heads++; }
            else
            { this.Tails++; }
            return flip;
        }
        /// <summary>
        /// Makes a random coinflip n times (1 by default) and stores the result in this object
        /// </summary>
        /// <param name="numberoftimes">
        /// Number of times to flip the coin
        /// </param>
        public void FlipAndStore(int numberoftimes)
        {
            for (int i = 0; i < numberoftimes; i++)
            {
                bool flip = FlipCoin();
                if (flip == false)
                { this.Heads++; }
                else
                { this.Tails++; }
            }
        }
        /// <summary>
        /// Makes a random coinflip
        /// </summary>
        /// <returns>false if the result is heads
        /// true if the result is tails
        /// </returns>
        public bool FlipCoin()
        {
            if (flipper.Next(2) == 0)
            { return false; }
            else
            { return true; }
        }
    }
}
