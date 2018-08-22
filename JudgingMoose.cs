// https://open.kattis.com/problems/judgingmoose
using System;
public class Solution{
    public static void Main(string[] args){
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        if(inputs.Length == 2){
            if(inputs[0] + inputs[1] == 0) Console.WriteLine("Not a moose");
            else{
                Array.Sort(inputs, 0, inputs.Length);
                Console.WriteLine($"{(inputs[0]!=inputs[1]?"Odd":"Even")} {inputs[1]*2}");
            }
        }   
    }
}