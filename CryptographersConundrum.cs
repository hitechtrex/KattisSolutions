// https://open.kattis.com/problems/conundrum
using System;
public class Solution{
    public static void Main(string[] args){
        string[] per = {"P", "e", "r"};
        string input = Console.ReadLine();
        int result = 0;
        for(int i = 0; i < input.Length; i++){
            if(string.Compare(Convert.ToString(input[i]), per[i%3], ignoreCase:true) != 0){
                result++;
            }
        }
        Console.WriteLine(result);
    }
} 