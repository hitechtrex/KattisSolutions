// https://open.kattis.com/problems/modulo
// Steve Jia
using System;
using System.Collections.Generic;
public class Solution{
    public static void Main(){
        List<int> results = new List<int>();
        for(int i = 0; i < 10; i++){
            int input = int.Parse(Console.ReadLine());
            int mod = input % 42;
            if(!results.Contains(mod)){
                results.Add(mod);
            }
        }
        Console.WriteLine(results.Count);
    }
} 