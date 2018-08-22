// https://open.kattis.com/problems/numberfun
using System;
public class Solution{
    public static void Main(string[] args){
        int count = int.Parse(Console.ReadLine());
        for(int i = 0; i < count; i++){
            int[] set = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = set[0];
            int b = set[1];
            int c = set[2];
            
            if(a + b == c || a * b == c){
                Console.WriteLine("Possible");
                continue;
            }
            
            double max = Math.Max(a, b);
            double min = Math.Min(a, b);
            if(max - min == c || (max / min).CompareTo((double)c)==0){
                Console.WriteLine("Possible");
                continue;
            }
            Console.WriteLine("Impossible");
        }
    }
}