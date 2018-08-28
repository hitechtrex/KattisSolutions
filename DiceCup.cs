// https://open.kattis.com/problems/dicecup
// Steve Jia
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution{
    public static void Main(string[] args){
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Dictionary<int, int> counts = new Dictionary<int, int>();
        for(int i = 1; i <= inputs[0]; i++){
            for(int j = 1; j <= inputs[1]; j++){
                var sum = i+j;
                if(counts.ContainsKey(sum)){
                    counts[sum]++;
                }
                else{
                    counts.Add(sum, 1);
                }
            }
        }
        var sorted = counts.OrderByDescending(kvp => kvp.Value);
        var filtered = sorted.Where(kvp => kvp.Value == sorted.First().Value);
        foreach(var thing in filtered){
            Console.WriteLine(thing.Key);
        }
    }
}