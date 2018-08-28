// https://open.kattis.com/problems/hissingmicrophone
// Steve Jia
using System;
public class Solution{
    public static void Main(string[] args){
        Console.WriteLine($"{(Console.ReadLine().Contains("ss") ? "" : "no ")}hiss");
    }
}