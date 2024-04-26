using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dividers2(int[] numbers)
            {
                int min = numbers[0];
                List<int> dividers = new List<int>();
                bool isDivider = true;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (min > numbers[i])
                    {

                        min = numbers[i];
                    }
                }
                for (int i = 2; i <= min; i++)
                {
                    isDivider = true;
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] % i != 0)
                        {
                            isDivider = false;
                        }
                    }
                    if (isDivider == true)
                    {
                        dividers.Add(i);
                    }
                }
                return dividers.ToArray();
            }
            string numbersOriginal = Console.ReadLine();
            string[] numbersString = numbersOriginal.Split(',');
            int[] numbersInt = Array.ConvertAll(numbersString,Int32.Parse);
            int[] testData = {42,12,18};
            int[] resultArray = dividers2(numbersInt);
            for(int i = 0;i<resultArray.Length;i++)
            {
                if (i+1 != resultArray.Length)
                {
                    Console.Write(resultArray[i] + ",");
                }
                else
                {
                    Console.Write(resultArray[i]);

                }
            }
            Console.ReadLine();
        }
    }
}
