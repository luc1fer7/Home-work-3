using System;

namespace Task_3
{
    class Converter
    {
        double UAH_USD;
        double UAH_EUR;
        double USD_UAH;
        double EUR_UAH;
        public double result = 0;

        public Converter(double UA_US, double UA_EU, double US_UA, double EU_UA)
        {
            UAH_USD = UA_US;
            UAH_EUR = UA_EU;
            USD_UAH = US_UA;
            EUR_UAH = EU_UA;
        }

        public void Convert(string Currency_1, string Currency_2, double value)
        {
            if (Currency_1 == "USD")
            {
                if (Currency_2 == "UAH")
                    result = value * USD_UAH;
                else
                {
                    Console.WriteLine("Sorry, this part of program is not developed now");
                    result = 0;
                }
            }
            else if (Currency_1 == "EUR")
            {
                if (Currency_2 == "UAH")
                    result = value * EUR_UAH;
                else
                {
                    Console.WriteLine("Sorry, this part of program is not developed now");
                    result = 0;
                }
            }
            else if (Currency_1 == "UAH")
            {
                if (Currency_2 == "EUR")
                    result = value / UAH_EUR;
                else
                    result = value / UAH_USD;
            }
            else
            {
                Console.WriteLine("We haven't currency like " + Currency_1);
                result = 0;
            }
            Console.WriteLine("{0} {2} converted to {1} {3}", value, result, Currency_1, Currency_2);
        }

    }

    class Command
    {
        public bool IsCommand(string command)
        {
            if (command == "EXIT")
            {
                return true;
            }
            else if (command == "USD")
            {
                return true;
            }
            else if (command == "EUR")
            {
                return true;
            }
            else if (command == "UAH")
            {
                return true;
            }
            else
                return false;
        }
        public int WhatCommand(string command)
        {
            if (command == "EXIT")
            {
                Console.WriteLine("Are you shure? Don`t do this, man....");
                command = Console.ReadLine();
                if (command == "YES")
                    return 0;
                else if (command == "yes")
                    return 0;
                else
                    return 1;

            }
            else if (command == "USD")
            {
                return 2;
            }
            else if (command == "UAH")
            {
                return 3;
            }
            else
                return 4;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Converter C = new Converter(26.32, 30.4, 26.59, 30.73);
            Command Com = new Command();

            string UserCommand;
            string Currency_1 = "", Currency_2 = "";
            double Value;
            int exit = 1;

            do
            {
                Console.WriteLine("\nFrom which currency do you want to convert?");
                Console.WriteLine("Dolar == USD || Euro == EUR  || Grivna == UAH|| Exit == EXIT");
                UserCommand = Console.ReadLine();
                Console.WriteLine();
                if (Com.IsCommand(UserCommand) == true)
                {
                    switch (Com.WhatCommand(UserCommand))
                    {
                        case 0:
                            exit = 0;
                            continue;
                        case 1:
                            exit = 1;
                            break;
                        default:
                            Currency_1 = UserCommand;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong operation!!!");
                    break;
                }

                Console.WriteLine("\nWhat currency do you want to convert to?");
                Console.WriteLine("Dolar == USD || Euro == EUR  || Grivna == UAH|| Exit == EXIT");
                UserCommand = Console.ReadLine();
                Console.WriteLine();
                if (Com.IsCommand(UserCommand) == true)
                {
                    switch (Com.WhatCommand(UserCommand))
                    {
                        case 0:
                            exit = 0;
                            continue;
                        case 1:
                            exit = 1;
                            break;
                        default:
                            Currency_2 = UserCommand;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong operation!!!");
                    break;
                }

                if (Com.IsCommand(UserCommand) == true)
                {
                    switch (Com.WhatCommand(UserCommand))
                    {
                        case 0:
                            exit = 0;
                            break;
                        case 1:
                            exit = 1;
                            break;
                        case 2:

                        case 3:

                        case 4:
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Type value of currency: ");
                                    Value = double.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Wrong type of value. Please write a number..\n");
                                }
                            }
                            while (true);
                            C.Convert(Currency_1, Currency_2, Value);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong command!!!");
                }


            } while (exit != 0);
        }
    }
}
