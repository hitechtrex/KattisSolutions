// https://open.kattis.com/problems/herman
// Steve Jia

using System;
public class Solution{
    public static void Main(){
        int radius = int.Parse(Console.ReadLine());
        Console.WriteLine("{0:0.000000}", Math.PI * Math.Pow(radius, 2));
        Console.WriteLine("{0:0.000000}", Math.Pow(radius, 2) * 2d);
    }
}