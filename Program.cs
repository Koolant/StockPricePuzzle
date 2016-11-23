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
            string input = Console.ReadLine();
            int solution;

            int[] pricesArr;

            inputParsing(input, out pricesArr);

            solution = getMaxProfit(pricesArr);

            Console.WriteLine(solution);

            Console.ReadLine();
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
            int diff;
            int answer = 0;

            for (int i = 0; i < stockPrices.Length; i++)
            {
                for (int k = i + 1; k < stockPrices.Length; k++)
                {
                    diff = stockPrices[i] - stockPrices[k];

                    if (answer < diff)
                    {
                        answer = diff;
                    }
                }
            }
            return answer;
        }
        
    }
}
