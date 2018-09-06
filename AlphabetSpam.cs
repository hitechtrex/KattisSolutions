// https://open.kattis.com/problems/alphabetspam
// Steve Jia

using System;
using System.Collections.Generic;
using System.Linq;
public class Solution{
    public static void Main(){
        string input = Console.ReadLine();
        List<double> counts = new List<double>();
        counts.Add(input.Count(c => c == '_'));
        counts.Add(input.Count(c => char.IsLower(c)));
        counts.Add(input.Count(c => char.IsUpper(c)));
        counts.Add(input.Count(c => !char.IsLetter(c) && c != '_'));
        foreach(double count in counts){
            Console.WriteLine(count / (double)input.Length);
        }
    }
}