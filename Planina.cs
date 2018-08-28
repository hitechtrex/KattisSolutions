// https://open.kattis.com/problems/planina
// Steve Jia
using System;
public class Solution{
    public static void Main(string[] args){
        int iterations = Int32.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(1 + Math.Pow(2, iterations), 2));
    }
}