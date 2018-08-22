// https://open.kattis.com/problems/bijele
using System;
public class Solution{
    public static void Main(string[] args){
        int[] set = new int[]{1,1,2,2,2,8};
        int[] has = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        string output = string.Empty;
        for (int i = 0; i < set.Length; i++){
            output += $"{set[i] - has[i]} ";
        }
        Console.WriteLine(output.Trim());
    }
}