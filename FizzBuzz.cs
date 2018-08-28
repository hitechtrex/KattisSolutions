// https://open.kattis.com/problems/fizzbuzz
// Steve Jia
using System;
public class Solution{
    public static void Main(string[] args){
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        for(int i = 1; i <= inputs[2]; i++)
        {
            Console.WriteLine(
                (i % inputs[0] == 0) ? 
                    ((i % inputs[1]==0) ? "FizzBuzz" : "Fizz") : 
                    ((i % inputs[1]==0) ? "Buzz" : i.ToString())
            );
        }
    }
}