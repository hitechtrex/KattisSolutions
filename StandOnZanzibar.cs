// https://open.kattis.com/problems/zanzibar
// Steve Jia

using System;
public class Solution{
    public static void Main(){
        int testCases = int.Parse(Console.ReadLine());
        for(int i = 0; i < testCases; i++){
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int outsiders = 0;
            for(int j = 1; j < inputs.Length; j++){
                int currentPopulation = inputs[j];
                if(currentPopulation == 0) break;
    
                int prevPopulation = inputs[j-1];
                int delta = currentPopulation - prevPopulation * 2;
                outsiders += delta > 0 ? delta : 0;
            }
            Console.WriteLine(outsiders);
        }
    }
}