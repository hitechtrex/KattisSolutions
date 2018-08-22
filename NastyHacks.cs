// https://open.kattis.com/problems/nastyhacks
using System;
public class Solution{
    public static void Main(string[] args){
        int count = int.Parse(Console.ReadLine());
        for(int i = 0; i < count; i++){
            int[] set = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if(set[1]-set[2] > set[0]) Console.WriteLine("advertise");
            else if(set[1]-set[2] < set[0]) Console.WriteLine("do not advertise");
            else Console.WriteLine("does not matter");
        }
    }
}