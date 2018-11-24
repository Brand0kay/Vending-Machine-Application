using System;
using System.IO;
using System.Collections.Generic;

namespace Capstone
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Item> vend = new List<Item>();
            using (StreamReader sr = new StreamReader("vendingmachine.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] test;
                    test = line.Split('|');
                    Item item = new Item(test[1], Decimal.Parse(test[2]), test[0], test[3]);
                    vend.Add(item);  
                }
            }
                menuDisplay mainMenu = new menuDisplay(vend);
          
            mainMenu.Display();
        }
    }
}
