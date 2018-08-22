// https://open.kattis.com/problems/zamka
using System;

public class Solution{
    public static void Main(string[] args){
        int lowerLimit = int.Parse(Console.ReadLine());
        int upperLimit = int.Parse(Console.ReadLine());
        int digitSum = int.Parse(Console.ReadLine());
        
        for(int i = lowerLimit; i <= upperLimit; i++){
            if(DigitSum(i) == digitSum) {
                Console.WriteLine(i);
                break;
            }
        }
        
        for(int i = upperLimit; i >= lowerLimit; i--){
            if(DigitSum(i) == digitSum){
                Console.WriteLine(i);
                break;
            }
        }
    }
    
    private static int DigitSum(int number){
        int sum = 0;
        while(number != 0){
            sum += number%10;
            number /= 10;
        }
        return sum;
    }
}