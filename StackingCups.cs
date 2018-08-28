// https://open.kattis.com/problems/cups
// Steve Jia
using System;
using System.Collections.Generic;
using System.Linq;
public class Solution{
    public static void Main(){
        int testCases = int.Parse(Console.ReadLine());
        var cups = new List<Tuple<string, int>>();
        for(int i = 0; i < testCases; i++){
            string[] inputs = Console.ReadLine().Split(' ');
            int radius;
            if(int.TryParse(inputs[0], out radius)){
                cups.Add(new Tuple<string, int>(inputs[1], radius/2));
            }
            else{
                cups.Add(new Tuple<string, int>(inputs[0], int.Parse(inputs[1])));
            }
        }
        
        var ordered = cups.OrderBy(t => t.Item2);
        foreach(var o in ordered){
            Console.WriteLine(o.Item1);
        }
    }
}