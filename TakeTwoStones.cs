// https://open.kattis.com/problems/twostones
// Steve Jia
using System;
public class Solution{
    public static void Main(string[] args){
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine(input%2==0 ? "Bob": "Alice");
    }
} 