// https://open.kattis.com/problems/tarifa
// Steve Jia
using System;
using System.Collections.Generic;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<int> inputs = new List<int>();
            while ((line = Console.ReadLine()) != null)
            {
                if (Int32.TryParse(line, out int temp))
                    inputs.Add(temp);
            }

            int MonthlyAllowance = inputs[0];
            //Console.WriteLine($"Monthly Allowance {MonthlyAllowance}");
            List<int> MonthlyUsages = inputs.GetRange(2, inputs[1]);
            //Console.WriteLine($"Usages: {MonthlyUsages}");

            int allowed = MonthlyAllowance;
            foreach (int usage in MonthlyUsages)
            {
                allowed = (usage >= allowed) ? 0 : allowed - usage;
                allowed += MonthlyAllowance;
                //Console.WriteLine($"Usage: {usage}, Allowed: {allowed}");
            }
            Console.WriteLine(allowed);
        }
    }
}
