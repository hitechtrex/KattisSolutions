// https://open.kattis.com/problems/oddmanout
using System;
using System.Linq;

public class Solution{
    public static void Main(){
        int testCases = int.Parse(Console.ReadLine());
        for(int i = 1; i <= testCases; i++){
            int numberGuests = int.Parse(Console.ReadLine());
            int[] iCodes = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var codeCount = iCodes.ToList().GroupBy(c => c);
            var odd = codeCount.Where(c => c.Count() == 1).FirstOrDefault().Key;
            Console.WriteLine($"Case #{i}: {odd}");
        }
    }
}