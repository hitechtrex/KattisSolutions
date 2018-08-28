// https://open.kattis.com/problems/apaxiaaans
// Steve Jia
using System;
using System.Text;

public class Solution{
    public static void Main(string[] args){
        string apaxName = Console.ReadLine();
        StringBuilder simplified = new StringBuilder();
        simplified.Append(apaxName[0]);
        for(int i = 1; i < apaxName.Length; i++){
            if(apaxName[i] != apaxName[i-1]){
                simplified.Append(apaxName[i]);
            }
        }
        Console.WriteLine(simplified.ToString());
    }
}