﻿using System;

namespace _07.TestSnipet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 4)
            {
                switch (i)
                {
                    case 1:
                    case 2:
                        Console.Write(i);
                        break;
                    case 3:
                        Console.Write(i);
                        break;
                        
                }
                i++;
            }
        }
    }
}
