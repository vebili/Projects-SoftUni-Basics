﻿using System;

namespace _04.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //град   coffee   water   beer   sweets  peanuts
            //Sofia   0.50    0.80    1.20    1.45    1.60
            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            //Varna   0.45    0.70    1.10    1.35    1.55

            string item = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (town == "Sofia")
            {
                if (item == "coffee")
                {
                    price = 0.50;                    
                }
                else if(item == "water")
                {
                    price = 0.80;
                }
                else if (item == "beer")
                {
                    price = 1.20;
                }
                else if (item == "sweets")
                {
                    price = 1.45;
                }
                else if (item == "peanuts")
                {
                    price = 1.60;
                }
            }
            else if(town == "Plovdiv")
            {
                if (item == "coffee")
                {
                    price = 0.40;
                }
                else if (item == "water")
                {
                    price = 0.70;
                }
                else if (item == "beer")
                {
                    price = 1.15;
                }
                else if (item == "sweets")
                {
                    price = 1.30;
                }
                else if (item == "peanuts")
                {
                    price = 1.50;
                }
            }
            else if (town == "Varna")
            {
                if (item == "coffee")
                {
                    price = 0.45;
                }
                else if (item == "water")
                {
                    price = 0.70;
                }
                else if (item == "beer")
                {
                    price = 1.10;
                }
                else if (item == "sweets")
                {
                    price = 1.35;
                }
                else if (item == "peanuts")
                {
                    price = 1.55;
                }
            }

            double total = price * quantity;
            Console.WriteLine(total);
        }
    }
}