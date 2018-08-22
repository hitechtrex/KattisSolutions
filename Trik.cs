// https://open.kattis.com/problems/trik
using System;
public class Solution{
    public static void Main(string[] args){
        string moves = Console.ReadLine();
        int current = 1;
        for(int i = 0; i < moves.Length; i++){
            switch(moves[i]){
                case 'A':
                    current = (current == 1) ? 2 : ((current==2) ? 1 : current);
                    break;
                case 'B':
                    current = (current == 2) ? 3 : ((current==3) ? 2 : current);
                    break;
                case 'C':
                    current = (current == 1) ? 3 : ((current==3) ? 1 : current);
                    break;
            }
        }
        Console.WriteLine(current);
    }
}