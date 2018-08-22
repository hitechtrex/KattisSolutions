// https://open.kattis.com/problems/batterup
using System;
using System.Linq;
public class Solution{
    public static void Main(string[] args){
        int atBats = int.Parse(Console.ReadLine());
        int[] appearances = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        appearances = appearances.Where(x => x >= 0d).ToArray();
        atBats = appearances.Count();
        double d = ((double)appearances.Sum())/((double)atBats);
        Console.WriteLine(d.ToString("G17"));
    }
} 