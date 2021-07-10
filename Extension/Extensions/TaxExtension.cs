using System;

namespace turhansel_extension.Extensions
{
    public static class TaxExtension
    {
        public static float CalculatePriceAfterTax(this float currentPrice, float taxPercentage)
        {
            if (taxPercentage < 0)
            {
                return currentPrice; 
                //İndirim yok alooo?
            }
            else{
            float taxRatio = (1 + taxPercentage / 100);
            return currentPrice * taxRatio;
            }
        }
    }
}
