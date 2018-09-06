// https://open.kattis.com/problems/beavergnaw
// Steve Jia

using System;
public class Solution{
    public static void Main(){
        while(true){
            string input = Console.ReadLine();
            if(input == "0 0") break;
            
            double one = 1.0, three = 3.0, six = 6.0;
            double[] values = Array.ConvertAll(input.Split(' '), double.Parse);
            double D = values[0];
            double Vdiff = values[1];
            double d_cube = Math.Pow(D, three) - (six * Vdiff / Math.PI);
            double d = Math.Pow(d_cube, one/three);
            Console.WriteLine(d);
        }
    }
}