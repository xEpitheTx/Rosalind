using System;
using System.Globalization;

namespace RabbitsAndRecurrenceRelations
{
    class Program
    {
        static void Main(string[] args)
        {
            //RabbitReproduction(31, 4);
            RabbitReproduction1(35, 5);
        }

        private static long RabbitReproduction(long numMonths, long litterSize)
        {
            if (numMonths == 1)
                return 1;
            if(numMonths == 2)
                return litterSize;
            long monthOne = RabbitReproduction(numMonths - 1, litterSize);
            long monthTwo = RabbitReproduction(numMonths - 2, litterSize);
            if (numMonths <= 4)
                return monthOne + monthTwo;
            else
                return monthOne + (monthTwo * litterSize);

        }

        private static void RabbitReproduction1(long n, long k)
        {
            //input: positive integers where n is up to 40 and k is up to 5. n is the number of months and k is how many 
            //offspring pairs a rabbit pair has
            //output: the total number of rabbit pairs that will be present after n months
            //bunny reproduction equation: any given month will contain the rabbits that were alive the previous month plus offspring (which is equal
            //to the number of rabbits from n - 2)
            //you start out with 2 rabbits in month 1
            long currentRabbits = 0;
            long lastMonthsRabbits = k;
            Console.WriteLine(currentRabbits);

            //month 2 you have your two rabbits + k
            for (int currentMonth = 1; currentMonth <= n; currentMonth++)
            {
                if (currentMonth == 1)
                {
                    currentRabbits = 1;
                }
                else if (currentMonth == 2)
                {
                    //this needs to be last month plus 2 months
                    currentRabbits += k;
                }
                else if (currentMonth <= 4)
                {
                    currentRabbits += k;
                }
                else
                {
                    //month 2+ you have rabbits from previous month + number of rabbits form current month - 2 months
                    long twoMonthsPriorRabbits = lastMonthsRabbits;
                    lastMonthsRabbits = currentRabbits;
                    currentRabbits += (twoMonthsPriorRabbits * k);
                    Console.WriteLine(currentRabbits);
                }
            }
            Console.WriteLine(currentRabbits);
        }
    }
}
