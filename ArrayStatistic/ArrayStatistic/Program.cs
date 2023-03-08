using System;

namespace ArrayStatistic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Resolve conflicts");
            //action array
            Console.WriteLine("Actions with array");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("count=" + OptionsManager.CountLess100(arr));
            Console.WriteLine($"Max={OptionsManager.MaxNum(arr)}");
            arr = OptionsManager.ReverseArr(arr);
            OptionsManager.PrintArr(arr);
            OptionsManager.SortArr(arr);
            Console.WriteLine("coundOdds=" + OptionsManager.CountOdds(arr));
            OptionsManager.PrintOdds(arr);
        }
    }
}
