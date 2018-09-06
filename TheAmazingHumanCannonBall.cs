// https://open.kattis.com/problems/humancannonball2
// Steve Jia

using System;
public class Solution{
    static double v0 = 0;
    static double radian = 0;
    public static void Main()
    {
        int counts = int.Parse(Console.ReadLine());
        for(int i = 0; i < counts; i++){
            double[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            v0 = inputs[0];
            radian = inputs[1] * Math.PI / 180d;
            double t = T(inputs[2]);
            double y = Y(t);
            string output = $"{((y >= inputs[3]+1 && y <= inputs[4]-1) ? "" : "Not ")}Safe";
            Console.WriteLine(output);
        }
    }
    
    public static double T(double x){
        return x / (v0 * Math.Cos(radian));
    }
    
    public static double Y(double t){
        double g = 9.81;
        double half = 0.5;
        return v0 * t * Math.Sin(radian) - half * g * Math.Pow(t, 2);
    }
} 