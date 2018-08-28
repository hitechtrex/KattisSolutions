// https://open.kattis.com/problems/ptice
// Steve Jia
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution{
    public static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        char[] answer = Console.ReadLine().ToCharArray();
        Dictionary<string, int> scores = new Dictionary<string, int>{
            {"Adrian", 0},
            {"Bruno", 0},
            {"Goran", 0}
        };
        
        var seqOne = SeqOne(length);
        var seqTwo = SeqTwo(length);
        var seqThree = SeqThree(length);
        for(int i = 0; i < answer.Length; i++){
            int same = answer[i] - seqOne[i];
            if(same == 0){
                scores["Adrian"]++;
            }
            
            same = answer[i] - seqTwo[i];
            if(same == 0){
                scores["Bruno"]++;
            }
            
            same = answer[i] - seqThree[i];
            if(same == 0){
                scores["Goran"]++;
            }
        }
        
        var sorted = scores.OrderBy(t => t.Value);
        var winners = scores.Where(t => t.Value == sorted.Last().Value).Select(p => p.Key);
        Console.WriteLine(sorted.Last().Value);
        foreach(var winner in winners){
            Console.WriteLine(winner);
        }
    }
    
    public static char[] SeqOne(int length){
        char[] letters = { 'A', 'B', 'C' };
        char[] sequence = new char[length];
        for(int i = 0; i < length; i++){
            sequence[i] = letters[i%3];
        }
        return sequence;
    }
    
    public static char[] SeqTwo(int length){
        char[] letters = { 'B', 'A', 'B', 'C' };
        char[] sequence = new char[length];
        for(int i = 0; i < length; i++){
            sequence[i] = letters[i%4];
        }
        return sequence;
    }
    
    public static char[] SeqThree(int length){
        char[] letters = { 'C', 'C', 'A', 'A', 'B', 'B' };
        char[] sequence = new char[length];
        for(int i = 0; i < length; i++){
            sequence[i] = letters[i%6];
        }
        return sequence;
    }  
} 