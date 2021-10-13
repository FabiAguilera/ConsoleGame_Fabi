using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThePriceisRightCosoleGame.Data;

namespace ThePriceisRightConsoleGame.UI
{//user interactions
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();

            //item descriptor

            Console.WriteLine("What is the price of the Swivel XL Pet Upright Vacuum? \n" +
                ""); 

            
            Console.WriteLine("Power through pet hair with a 25% more powerful motor and WindTunnel technology that \n" +
                "creates edge-to-edge suction in tight corners and hard-to-reach spots. \n" +
                "Filter made with HEPA Media, which captures 99.97% of dust and particles. \n" +
                "Maximize pet hair, dirt, and debris pickup on multiple surfaces including carpets, hard floors, upholstry, and more.");
            Console.WriteLine("What is the price of the vacuum: ");
            GameRepo gameRepo = new GameRepo();

            decimal priceGuess = Convert.ToDecimal(Console.ReadLine());
            
            Item itemOne = new Item("vacuum", 169.99m, priceGuess);
            gameRepo.AddItem(itemOne);
            bool result = gameRepo.GuessCheck(priceGuess, itemOne);
            decimal guess = Convert.ToDecimal(priceGuess);
            
            Console.ReadLine();

            Console.Clear();



            Console.WriteLine("The next item up for bid is a new TV! Enjoy the Samsung neo QLED smart TV with amazing detail in both the darkest and brightest scenes with Quantum Matrix Technology & Quantum Mini LED. \n" +
                "Object Tracking Sound+ delivers dynamic sound that keeps up with the on-screen action.");
            Console.WriteLine("Please enter your bid: ");
          
            GameRepo gameRepoTwo = new GameRepo();

            decimal priceGuessTwo = Convert.ToDecimal(Console.ReadLine());

            Item itemTwo = new Item("TV", 2099.99m, priceGuessTwo);
            gameRepo.AddItem(itemTwo);
            bool resultTwo = gameRepo.GuessCheck(priceGuessTwo, itemTwo);
            decimal guessTwo = Convert.ToDecimal(priceGuessTwo);

            Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Blend with ease in this stylish, Cuisinart Smartpower Chrome Finish Blender. \n" +
                " This powerful blender features stainless steel blades, a 40-ounce glass jar with dripless spout, ice crusher capacity, touch pad controls with indicator lights, and a leak-resistant cover");

            Console.WriteLine("Please enter your bid: ");

            GameRepo gameRepoThree = new GameRepo();

            decimal priceGuessThree = Convert.ToDecimal(Console.ReadLine());

            Item itemThree = new Item("Blender", 2099.99m, priceGuessThree);
            gameRepo.AddItem(itemThree);
            bool resultThree = gameRepo.GuessCheck(priceGuessThree, itemThree);
            decimal guessThree = Convert.ToDecimal(priceGuessThree);

            Console.ReadLine();





        }
    }
}
