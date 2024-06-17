using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int appleAmount;
            int applePrice;
            float radius;
            float speed;
            bool isOpen;
            bool haveApple;
            string appleAmountText;
            string applePriceText;
            double weight = 0.25;
            char firstLetterAlphabet = 'A';

            appleAmount = 3;
            applePrice = Convert.ToInt32(weight) * appleAmount;

            radius = 2;
            speed = 13.125f;

            isOpen = true;
            haveApple = appleAmount > 0;

            appleAmountText = "Apple: " + appleAmount;
            applePriceText = applePrice.ToString();

        }
    }
}
