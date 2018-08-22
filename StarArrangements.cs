// https://open.kattis.com/problems/stararrangements
using System;
public class Solution{
    public static void Main(string[] args){
        int stars = int.Parse(Console.ReadLine());
        Console.WriteLine($"{stars}:");
        for(int i = 2; i < stars; i++){
            for(int j = i-1; j <= i; j++){
                int a = (stars / (i+j)) * (i+j);
                int b = stars - a;
                if(b % i == 0 || i+j==stars){
                    Console.WriteLine($"{i},{j}");  
                }
            }
            if(i > stars/2 + 1){ break; }
        }
    }
}