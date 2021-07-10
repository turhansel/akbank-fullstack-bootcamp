using System;
using turhansel_extension.Extensions;
namespace turhansel_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much?");
            float product = float.Parse(Console.ReadLine());
            Console.WriteLine("What about tax ratio?");
            float priceAfterTax = product.CalculatePriceAfterTax(float.Parse(Console.ReadLine()));
            Console.WriteLine("The price of your product is" + " " + priceAfterTax + "€");
        }
    }
}
