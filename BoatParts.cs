// https://open.kattis.com/problems/boatparts
// Steve Jia

using System;
using System.Collections.Generic;
public class Solution{
    public static void Main(){
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int numParts = inputs[0];
        int numDays = inputs[1];
        List<string> parts = new List<string>();
        for(int i = 0; i < numDays; i++){
            string part = Console.ReadLine();
            if(!parts.Contains(part)){
                parts.Add(part);
            }
            if(parts.Count == numParts){
                Console.WriteLine(i+1);
                return;
            }
        }
        Console.WriteLine("paradox avoided");
    }
}