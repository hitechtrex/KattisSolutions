// https://open.kattis.com/problems/estimatingtheareaofacircle
// Steve Jia

using System;
public class Solution{
    public static void Main(){
        while(true){
            string input = Console.ReadLine();
            if(input == "0 0 0") break;
            
            double[] values = Array.ConvertAll(input.Split(' '), double.Parse);
            double radius = values[0];
            double percentage = values[2] / values[1];
            Console.WriteLine($"{Math.PI * Math.Pow(radius, 2)} {Math.Pow(radius * 2, 2) * percentage}");
        }
    }
}