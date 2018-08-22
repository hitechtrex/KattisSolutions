// https://open.kattis.com/problems/autori
using System;
using System.Linq;
public class Solution{
    public static void Main(string[] args){
        string[] inputs = Console.ReadLine().Split('-');
        Console.WriteLine(String.Join("", inputs.Select(x => x[0])));
    }
} 