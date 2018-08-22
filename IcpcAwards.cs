// https://open.kattis.com/problems/icpcawards
using System;
using System.Collections.Generic;
public class Solution{
    public static void Main(string[] args){
        int teams = int.Parse(Console.ReadLine());
        Dictionary<string, string> winners = new Dictionary<string, string>();
        string line;
        for(int i = 0; i < teams && ((line=Console.ReadLine()) != null); i++){
            string[] info = line.Split(' ');
            if(!winners.ContainsKey(info[0])){
                winners.Add(info[0], info[1]);
            }
            
            if(winners.Count == 12){ break; }
        }
        
        foreach(var kvp in winners){
            Console.WriteLine($"{kvp.Key} {kvp.Value}");
        }
    }
}