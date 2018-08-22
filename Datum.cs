// https://open.kattis.com/problems/datum
using System;
public class Solution{
    public static void Main(string[] args){
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        DateTime date = new DateTime(2009, inputs[1], inputs[0]);
        Console.WriteLine(date.DayOfWeek);
    }
} 