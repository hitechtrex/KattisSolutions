// https://open.kattis.com/problems/speedlimit
// Steve Jia

using System;
public class Solution{
    public static void Main(){
        while(true){
            int trip = int.Parse(Console.ReadLine());
            if(trip == -1) break;
            
            int total = 0, intime = 0, curspeed = 0, curtime = 0;
            for(int i = 0; i < trip; i++){
                int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                curspeed = inputs[0];
                curtime = inputs[1];
                total += ((curspeed) * (curtime - intime));
                intime = curtime;
            }
            Console.WriteLine($"{total} miles");
        }
    }
}