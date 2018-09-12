// https://open.kattis.com/problems/volim
// Steve Jia
using System;
public class Solution{
    public static void Main(){
        const int totalPlayers = 8, totalTime = 210;
        int currentTime = 0;
        int currentPlayer = int.Parse(Console.ReadLine()) - 1;
        int numQuestions = int.Parse(Console.ReadLine());
        for(int i = 0; i < numQuestions; i++){
            string[] inputs = Console.ReadLine().Split();
            int time = int.Parse(inputs[0]);
            string answer = inputs[1];
            
            currentTime += time;
            if(currentTime >= totalTime) break;
            
            if(answer == "T"){
                currentPlayer = (currentPlayer + 1) % totalPlayers;
            }
        }
        Console.WriteLine(currentPlayer + 1);
    }
}