// https://open.kattis.com/problems/nodup
// Steve Jia
using System;
using System.Linq;
public class Solution{
    public static void Main(string[] args){
        string[] input = Console.ReadLine().Split(' ');
        string result = "yes";
        foreach(var word in input.Distinct()){
            if(input.Count(x => x == word) > 1) result = "no";
        }
        
        Console.WriteLine(result);
    }
} 