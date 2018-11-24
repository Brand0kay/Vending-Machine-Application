using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class SubMenu : Logger
    {
        private List<Item> vend;

        public SubMenu()
        {
        }

        public SubMenu(List<Item> vend)
        {
            this.vend = vend;
        }

        public decimal DisplayBalance { get; set; }
        public decimal MoneyChange { get; set; }
        public string Action { get; set; }
    

        /// <summary>
        /// This displays three options to choose
        /// </summary>
        public void DisplaySub()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(" Beep Boop Purchase Menu ");
                Console.WriteLine("1] >> Feed Me Money ");
                Console.WriteLine("2] >> What do you want ");
                Console.WriteLine("3] >> Finish Transaction or Return to Main Menu ");

                Console.WriteLine($" Current Balance: ${DisplayBalance} ");

                Console.Write(" Choose your option ");

                string input = Console.ReadLine();

                //Option 1 Enter money and updates balance
                if (input == "1")
                {
                    // breaks if given letter
                    Console.WriteLine(" Please enter $1, $2, $5 or $10: ");
                    int moneyIn = Convert.ToInt32(Console.ReadLine());

                    if (moneyIn == 1)
                    {
                        DisplayBalance += moneyIn;
                        MoneyChange = moneyIn;
                        Action = "Feed Money";
                        Logger.Log(this);
                    }
                    else if (moneyIn == 2)
                    {
                        DisplayBalance += moneyIn;
                        MoneyChange = moneyIn;
                        Action = "Feed Money";
                        Logger.Log(this);
                    }
                    else if (moneyIn == 5)
                    {
                        DisplayBalance += moneyIn;
                        MoneyChange = moneyIn;
                        Action = "Feed Money";
                        Logger.Log(this);
                    }
                    else if (moneyIn == 10)
                    {
                        DisplayBalance += moneyIn;
                        MoneyChange = moneyIn;
                        Action = "Feed Money";
                        Logger.Log(this);
                    }
                    else
                    {
                        Console.WriteLine(" -Vendo-Matic 500 spits that back out- ");
                    }
                }
                //option 2 Choose what item to select
                else if (input == "2")
                {
                    Console.WriteLine(" Please select an available item: ");
                    Console.WriteLine("");
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
                    string slotRead = Console.ReadLine();

                    bool isValid = false;

                    foreach (Item i in vend)
                    {
                        if (i.SlotID.Contains(slotRead))
                        {
                            isValid = true;
                        }
                    }

                    foreach (Item item in vend)
                    {
                        if (slotRead == item.SlotID)
                        {
                            if (DisplayBalance > item.Price && item.Quantity > 0)
                            {
                                Console.WriteLine($" - Dispenses {item.Name} -");
                                if(item.FoodType == "Chip")
                                {
                                    Console.WriteLine("BEEP BOOP");
                                    Console.WriteLine("Crunch Crunch, Yum.");
                                }
                                else if(item.FoodType == "Candy")
                                {
                                    Console.WriteLine("BEEP BOOP");
                                    Console.WriteLine("Munch Munch, Yum.");
                                }
                                else if (item.FoodType == "Drink")
                                {
                                    Console.WriteLine("BEEP BOOP");
                                    Console.WriteLine("Glug Glug, Yum.");
                                }
                                else if (item.FoodType == "Gum")
                                {
                                    Console.WriteLine("BEEP BOOP");
                                    Console.WriteLine("Chew Chew, Yum.");
                                }
                                DisplayBalance -= item.Price;
                                item.Quantity -= 1;
                                Action = item.Name + " " + item.SlotID;
                                MoneyChange = item.Price;
                                Logger.Log(this);
                                break;
                            }
                            else if (DisplayBalance < item.Price && item.Quantity > 0)
                            {
                                Console.WriteLine(" -BZZT Not enough Funds BZZT- ");
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" SOLD OUT...Pesky Human ");
                            }
                            
                        }
                        if (!isValid)
                        {
                            Console.WriteLine(" -BZZT Error BZZT- ");
                            break;
                        }
                    }
                }
                //Finished transaction, change returned
                else if (input == "3")
                {
                    decimal money = DisplayBalance;
                    int changeQ = 0;
                    int changeD = 0;
                    int changeN = 0;

                    if (money > (decimal).25)
                    {
                        changeQ = (int)(money / (decimal).25);
                        money = money - (changeQ * (decimal).25);
                    }
                    if (money > (decimal).10)
                    {
                        changeD = (int)(money / (decimal).1);
                        money = money - (changeD * (decimal).1);
                    }
                    if (money >= (decimal).05)
                    {
                        changeN = (int)(money / (decimal).05);
                        money = money - (changeN * (decimal).05);
                    }
                    decimal storedBalance = DisplayBalance;
                    DisplayBalance = 0M;
                    Console.WriteLine(" Collect your change below ");
                    Console.WriteLine($" {changeQ} quarter(s), {changeD} dime(s), and {changeN} nickel(s) plop out ");
                    MoneyChange = storedBalance;
                    Logger.Log(this);
                    Console.WriteLine("Returning to Main Menu");
                    Console.WriteLine();
                    break;
                }               
            }
        }
    }
}
