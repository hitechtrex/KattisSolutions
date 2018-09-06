// https://open.kattis.com/problems/acm
// Steve Jia

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution{
    public static void Main(){
        var answers = new Dictionary<string, Problem>();
        while(true){
            string input = Console.ReadLine();
            if(input == "-1") break;
            
            string[] content = input.Split(' ');
            string probId = content[1];
            if(!answers.ContainsKey(probId)){
                answers.Add(probId, new Problem{ ID = probId });
            }
            
            var problem = answers[probId];
            if(problem.IsSolved) continue;
            if(content[2] == "right"){
                int time = int.Parse(content[0]);
                problem.SolvedTime = time;
                problem.IsSolved = true;
            }
            else{
                problem.PenaltyCount++;
            }
            
            //Console.WriteLine(answers);
        }
        
        var correct = answers.Where(t => t.Value.IsSolved);
        //Console.WriteLine(correct);
        int score = 0;
        foreach(var right in correct){
            score += right.Value.SolvedTime + (20 * right.Value.PenaltyCount);
        }
        Console.WriteLine($"{correct.Count()} {score}");
    }
}

public class Problem{
    public string ID {get; set;}
    public bool IsSolved {get; set;}
    public int SolvedTime {get; set;}
    public int PenaltyCount {get; set;}
}