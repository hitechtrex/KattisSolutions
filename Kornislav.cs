// https://open.kattis.com/problems/kornislav
using System;
using System.Linq;
public class Solution{
    public static void Main(string[] args){
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' ').Distinct().ToArray(), int.Parse);
        if(inputs.Length == 1){
            Console.WriteLine(inputs[0] * inputs[0]);
        }
        else if(inputs.Length == 2) {
            Console.WriteLine(inputs[0] * inputs[1]);
        }
        else{
            Array.Sort(inputs, 0, inputs.Length);
            Console.WriteLine(inputs[inputs.Length-2] * inputs[0]);
        }
    }
}