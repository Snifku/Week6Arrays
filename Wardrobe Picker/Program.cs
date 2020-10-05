using System;

namespace Wardrobe_Picker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wardrobe = { "hat", "hoodie", "jeans", "dress", "shirt" };
            string[] colors = { "red", "blue", "white", "green", "pink" };
            string[] patterns = { "flowery", "striped", "polka dot", "circles", "checked" };

            Random rnd = new Random();
            Console.WriteLine("would you like some fashion advice?");
            string userinput = Console.ReadLine();
            if(userinput == "no")
            {
                Console.WriteLine("farewall!");

            }else
            {
                Console.WriteLine($"Today you should wear" +
                    $"{colors[rnd.Next(0, colors.Length)]} " +
                    $"{patterns[rnd.Next(0, patterns.Length)]} " + 
                    $"{wardrobe[rnd.Next(0, wardrobe.Length)]}");

            }
            
            
           


        }
    }
}
