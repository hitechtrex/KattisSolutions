// https://open.kattis.com/problems/hangingout
// Steve Jia

using System;
public class Solution{
    public static void Main(){
        int[] conditions = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int limit = conditions[0];
        int events = conditions[1];
        int current = 0, denied = 0;
        for(int i = 0; i < events; i++){
            string[] inputs = Console.ReadLine().Split(' ');
            int count = int.Parse(inputs[1]);
            if(inputs[0] == "enter"){
                if(current + count > limit){
                    denied++;
                }
                else{
                    current += count;
                }
            }
            else if(inputs[0] == "leave"){
                current = (current-count < 0) ? 0 : current-count;
            }
        }
        Console.WriteLine(denied);
    }
}