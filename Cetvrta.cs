// https://open.kattis.com/problems/cetvrta
// Steve Jia
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution{
    public static void Main(string[] args){
        List<int> xs = new List<int>();
        List<int> ys = new List<int>();
        for(int i = 0; i < 3; i++){
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            xs.Add(inputs[0]);
            ys.Add(inputs[1]);
        }
        
        var j = xs.GroupBy(x => x).OrderBy(grp => grp.Count()).First();
        var k = ys.GroupBy(x => x).OrderBy(grp => grp.Count()).First();
        
        Console.WriteLine($"{j.Key} {k.Key}");
    }
}