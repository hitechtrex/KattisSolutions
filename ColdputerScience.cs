// https://open.kattis.com/problems/cold
// Steve Jia
using System;
using System.Linq;
public class Solution{
    public static void Main(string[] args){
        Console.ReadLine();
        int[] temps = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        Console.WriteLine(temps.Count(t => t < 0));
    }
} 