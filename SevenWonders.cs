// https://open.kattis.com/problems/sevenwonders
using System;
public class Solution{
    public static void Main(string[] args){
        int numT = 0;
        int numC = 0;
        int numG = 0;
        string input = Console.ReadLine();
        foreach(char c in input){
            if(c == 'T') numT++;
            else if(c == 'C') numC++;
            else if(c == 'G') numG++;
        }
        
        int min = numT < numC ? (numT < numG ? numT : numG) : (numC < numG ? numC : numG);
        
        Console.WriteLine(Math.Pow(numT,2) + Math.Pow(numC,2) + Math.Pow(numG,2) + 7 * min);
    }
}