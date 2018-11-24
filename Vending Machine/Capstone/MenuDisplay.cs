using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    /// <summary>
    /// main menu and displays items in vending machine
    /// </summary>
    public class menuDisplay
    {
        private List<Item> vend;

        public menuDisplay()
        {
        }

        public menuDisplay(List<Item> vend)
        {
            this.vend = vend;
        }
        /// <summary>
        /// display method which displays the vending machine goods
        /// </summary>
        public void Display()
        {
            while (true)
            {
                Header();
                Console.WriteLine();
                Console.WriteLine("Beep Boop Main Menu: ");
                Console.WriteLine("1] >> Display Item ");
                Console.WriteLine("2] >> Purchase Item ");
                Console.WriteLine("Q] >> Quit");
                Console.Write("Beep Boop Make your decision human: ");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine(" Booting up display items. . . ");
                    Console.WriteLine();

                    foreach (Item item in vend)
                    {
                        if (item.Quantity > 0)
                        {
                            Console.WriteLine($"{item.SlotID} | {item.Name} | {item.Price} | {item.Quantity}");
                        }
                        else if (item.Quantity == 0)
                        {
                            Console.WriteLine($"Sold Out");
                        }
                    }
                    Console.WriteLine($"");
                }
                else if (input == "2")
                {
                    Console.WriteLine(" Booting up the purchase display. . .  ");
                    SubMenu submenu = new SubMenu(vend);
                    submenu.DisplaySub();
                }
                else if (input == "Q")
                {
                    Console.WriteLine(" Vendo-Matic 500 shutting down ");
                    break;
                }
                else
                {
                    Console.WriteLine(" Bzzt Bzzt error try again ");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void Header()
        {
            Console.WriteLine("Beep Boop I am Vendo-Matic 500 ");
            Console.WriteLine("Enter your command Beep Boop.");
        }
    }
}
