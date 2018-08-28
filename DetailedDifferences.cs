// https://open.kattis.com/problems/detaileddifferences
// Steve Jia
using System;
public class Solution{
    public static void Main(string[] args){
        int pairs = int.Parse(Console.ReadLine());
        for(int i = 0; i < pairs; i++){
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            if(first.Length != second.Length){ throw new ArgumentException(); }
            string result = string.Empty;
            for(int j = 0; j < first.Length; j++){
                result += (first[j] == second[j]) ? "." : "*";
            }
            Console.WriteLine($"{first}\n{second}\n{result}\n");
        }
    }
}