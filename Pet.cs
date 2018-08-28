// https://open.kattis.com/problems/pet
// Steve Jia
using System;
using System.Linq;
public class Solution{
    public static void Main(string[] args){
        int maxIndex = 0;
        int maxSum = 0;
        string line;
        for(int i = 0; i < 5 && ((line = Console.ReadLine()) != null); i++){
            int sum = Array.ConvertAll(line.Split(' '), Int32.Parse).Sum();
            if(sum > maxSum){
                maxSum = sum;
                maxIndex = i;
            }
        }
        Console.WriteLine($"{maxIndex+1} {maxSum}");
    }
}