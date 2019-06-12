using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptopselector
{
    class Program
    {

        static UInt64 LaptopPrice1 = 0;
        static UInt64 LaptopPrice2 = 0;
        static Boolean validEntry = false;
        static ulong returnedValue;
        static ConsoleKey choice;
                static void Main(string[] args)
        {
            do
            {

                returnedValue = Preferredlaptop();

                if (returnedValue != 0)
                {
                    Console.WriteLine("Preffered Laptop Price is " + returnedValue);

                }
                else
                {
                    Console.WriteLine("Invalid Price combination");
                }

                Console.Write("Press X to Quit, Any other Key to Continue");
                choice = Console.ReadKey(true).Key;
                Console.Clear();
            } while (choice != ConsoleKey.X);

        }

        public static UInt64 Preferredlaptop()
        {
            
            do
            {

                try
                {

                    Console.Write("Enter the Price of the 1st Laptop : ");
                    LaptopPrice1 = Convert.ToUInt64(Console.ReadLine());
                    validEntry = true;
                }
                catch
                {
                    displayerr();
                }

            } while (validEntry == false);

            validEntry = false;

            do
            {

                try
                {
                    Console.Write("Enter the Price of the 2nd Laptop : ");
                    LaptopPrice2 = Convert.ToUInt64(Console.ReadLine());
                    validEntry = true;
                }
                catch
                {
                    displayerr();

                }

            } while (validEntry == false);


            if (LaptopPrice1 % 2 == 0 && LaptopPrice2 % 2 == 0)
            {

                if (LaptopPrice1 > LaptopPrice2)
                {
                    return LaptopPrice2;
                }
                else if (LaptopPrice1 != LaptopPrice2)
                {
                    return LaptopPrice1;

                }
                else
                {
                    return 0;
                }


            }
            else if ((LaptopPrice1 % 2 == 0 && LaptopPrice2 % 2 != 0) || (LaptopPrice1 % 2 != 0 && LaptopPrice2 % 2 == 0))
            {
                GetMax(LaptopPrice1, LaptopPrice2);
                return LaptopPrice1 > LaptopPrice2 ? LaptopPrice1 : LaptopPrice2;
            }
            else
            {
                return 0;

            }

        }
        // Compare the value to get the bigger number
            public static ulong GetMax(ulong firstvalue1, ulong secondvalue2)
            {
                if (firstvalue1 > secondvalue2)
                {
                    return firstvalue1;
                }

                else if (firstvalue1 < secondvalue2)
                {
                    return secondvalue2;
                }
                else
                {
                    return secondvalue2;
                }
            }

        // Error message feedback and clears screen
            public static bool displayerr()
            {
                Console.Write("Positive Numerical Values only are allowed ! Press any key to continue");
                Console.ReadLine();
                Console.Clear();
                validEntry = false;
                return validEntry;
            }


        }
    }

