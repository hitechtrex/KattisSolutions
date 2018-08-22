// https://open.kattis.com/problems/bela
using System;
using System.Collections.Generic;

public class Solution{
    public static void Main(string[] args){
        Dictionary<string, int> dom = new Dictionary<string, int>{
            {"A", 11},
            {"K", 4},
            {"Q", 3},
            {"J", 20},
            {"T", 10},
            {"9", 14},
            {"8", 0},
            {"7", 0},
        };
        Dictionary<string, int> nondom = new Dictionary<string, int>(){
            {"A", 11},
            {"K", 4},
            {"Q", 3},
            {"J", 2},
            {"T", 10},
            {"9", 0},
            {"8", 0},
            {"7", 0},
        };
        
        string[] inputs = Console.ReadLine().Split(' ');
        int sets = int.Parse(inputs[0]);
        string domSuit = inputs[1];
        int score = 0;
        for(int i = 0; i < sets*4; i++){
            string card = Console.ReadLine();
            score += (Convert.ToString(card[1]) == domSuit) ? (dom[Convert.ToString(card[0])]) : (nondom[Convert.ToString(card[0])]);
        }
        Console.WriteLine(score);
    }
}