// https://open.kattis.com/problems/kemija08
// Steve Jia
using System;
using System.Collections.Generic;
using System.Text;
public class Solution{
    public static void Main(){
        string input = Console.ReadLine();
        List<char> vowels = new List<char>{'a', 'e', 'i', 'o', 'u'};
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < input.Length; i++){
            sb.Append(input[i]);
            if(vowels.Contains(input[i])){
                i += 2;
            }
        }
        Console.WriteLine(sb.ToString());
    }
}