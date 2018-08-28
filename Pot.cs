// https://open.kattis.com/problems/pot
// Steve Jia
using System;
using System.Collections.Generic;
public class Solution{
    public static void Main(string[] args){
        int count = Int32.Parse(Console.ReadLine());
        List<int> pots = new List<int>();
        for(int i = 0; i < count; i++){
            pots.Add(Int32.Parse(Console.ReadLine()));
        }
        
        int output = 0;
        foreach(int pot in pots){
            output += (int)Math.Pow(pot/10, pot%10);
        }
        Console.WriteLine(output);
    }
}