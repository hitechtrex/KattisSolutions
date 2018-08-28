// https://open.kattis.com/problems/reversebinary
// Steve Jia
using System;
using System.Linq;
public class Solution{
    public static void Main(string[] args){
        int input = int.Parse(Console.ReadLine());
        string reversedString = String.Join("", Convert.ToString(input, 2).Reverse());
        Console.WriteLine(Convert.ToInt32(reversedString, 2));
    }
}