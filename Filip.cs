// https://open.kattis.com/problems/filip
using System;
using System.Linq;
public class Solution{
    public static void Main(string[] args){
        string[] inputs = Console.ReadLine().Split(' ');
        int[] outputs = Array.ConvertAll(inputs, i => Int32.Parse(String.Join("", i.Reverse().ToArray())));
        Console.Write(Math.Max(outputs[0], outputs[1]));
    }
}