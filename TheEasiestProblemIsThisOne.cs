// https://open.kattis.com/problems/easiest
// Steve Jia
using System;

public class Solution{
    public static void Main(string[] args){
        int input = -1;
        while(true){
            input = int.Parse(Console.ReadLine());
            if(input == 0) return;
            for(int i = 11; i < 100000; i++){
                if(GetSum(input) == GetSum(input * i)){
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
    
    public static int GetSum(int a){
        int sum = 0;
        while(a != 0){
            sum += a%10;
            a /= 10;
        }
        return sum;
    }
}