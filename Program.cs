using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int solution;
            int[] pricesArr;

            while (true)
            {
                Console.WriteLine("Please input time indexed stock prices in the following format: x1 x2 x3\r\nType 'exit' to quit.");

                input = Console.ReadLine();
                    
                if (input == "exit")
                {
                    return;
                }

                inputParsing(input, out pricesArr);

                solution = getMaxProfit(pricesArr);

                Console.WriteLine("\r\nThe maximum profit was: " + solution + "\r\n");

                System.Threading.Thread.Sleep(2000);
            }
        }

        public static void inputParsing(string line, out int[] prices)
        {
            string[] splitLine = line.Split(' ');
            prices = new int[splitLine.Length];
            int count = 0;
            int number;

            foreach (string element in splitLine)
            {
                bool success = int.TryParse(element, out number);

                if (success)
                {
                    prices[count] = number;
                    count += 1;
                }
                else
                {
                    Console.WriteLine("Unexpected string {0} , failed to parse.", element);
                }
            }
        }


        public static int getMaxProfit(int[] stockPrices)
        {
            int minVal = stockPrices[0];
            int maxProfit = 0;

            for (int i = 0; i < stockPrices.Length; i++)
            {
                int element = stockPrices[i];
                    
                if (element < minVal)
                {
                    minVal = element;
                }

                if (maxProfit < element - minVal)
                {
                    maxProfit = element - minVal;
                }
                
            }
            return maxProfit;
        }
        
    }
}
