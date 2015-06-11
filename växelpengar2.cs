using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            doStuff();
        }
        private static void doStuff()
        {
            //Deklarering av variabler
            double totalSum;
            double roundingOfAmount;
            uint costumersAmount;
            uint toPay;
            uint change;

            while (true)
            {
                try
                {
                    //Värden från tangentbordet läses in.  
                    Console.Write("Ange totalsumma     : ");
                    totalSum = double.Parse(Console.ReadLine());

                    if (totalSum < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nTotalsumman är för liten. Köpet kunde inte genomföras.");
                        Console.ResetColor();
                        return;
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFel! erhållet belopp felaktigt.");
                    Console.ResetColor();
                }
            }

            while (true)
            {
                try
                {
                    //Värden från tangetbordet läses in
                    Console.Write("Ange erhållet belopp: ");
                    costumersAmount = uint.Parse(Console.ReadLine());
                    toPay = (uint)Math.Round(totalSum);
                    roundingOfAmount = toPay - totalSum;

                    change = costumersAmount - toPay;

                    if (costumersAmount < toPay)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nErhållet belopp är för litet. Köpet kunde inte genomföras.");
                        Console.ResetColor();
                        return;
                    }
                    else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nFel! Erhållet belopp felaktigt.");
                    Console.ResetColor();
                }
            }
            //Uträkningar görs och skriver ut ett kvitto
            Console.WriteLine("\nKVITTO ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Totalt\t\t: {0,10:c} \t", totalSum);
            Console.WriteLine("Öresavrundning\t: {0,10:c} \t", roundingOfAmount);
            Console.WriteLine("Att betala\t: {0,10:c0} \t", toPay);
            Console.WriteLine("Kontant \t: {0,10:c0} \t", costumersAmount);
            Console.WriteLine("Tillbaka \t: {0,10:c0} \t", change);
            Console.WriteLine("---------------------------");

            //kundens växel räknas ut i antal valörer med hjälp av modulus.
            if (change > 500)
            {
                Console.WriteLine("500-lappar\t: {0}", change / 500);
                change = change % 500;
            }
            if (change > 100)
            {
                Console.WriteLine("100-lappar\t: {0}", change / 100);
                change = change % 100;
            }
            if (change > 50)
            {
                Console.WriteLine("50-lappar\t: {0}", change / 50);
                change = change % 50;
            }
            if (change > 20)
            {
                Console.WriteLine("20-lappar\t: {0}", change / 20);
                change = change % 20;
            }
            if (change > 10)
            {
                Console.WriteLine("10-kronor\t: {0}", change / 10);
                change = change % 10;
            }
            if (change > 5)
            {
                Console.WriteLine("5-kronor\t: {0}", change / 5);
                change = change % 5;
            }
            if (change > 1)
            {
                Console.WriteLine("1-kronor\t: {0}", change);
            }

        }
    }
}


