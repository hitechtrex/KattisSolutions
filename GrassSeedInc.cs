// https://open.kattis.com/problems/grassseed
using System;
public class Solution{
    public static void Main(string[] args){
        double cost = double.Parse(Console.ReadLine());
        int lots = int.Parse(Console.ReadLine());
        double totalArea = 0d;
        for(int i = 0; i < lots; i++){
            double[] size = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            totalArea += size[0] * size[1];
        }
        Console.WriteLine("{0:R}", cost * totalArea);
    }
} 