// https://open.kattis.com/problems/oddities
// Steve Jia
using System;
public class Solution{
    public static void Main(string[] args){
        int count = Int32.Parse(Console.ReadLine());
        string line;
        int number;
        for(int i = 0; i < count && ((line=Console.ReadLine()) != null); i++){
            number = Int32.Parse(line);
            Console.WriteLine($"{number} is {(number%2==0 ? "even" : "odd")}");
        }
    }
}