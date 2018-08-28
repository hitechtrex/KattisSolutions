// https://open.kattis.com/problems/skener
// Steve Jia
using System;
using System.Collections.Generic;
using System.Text;
public class Solution{
    public static void Main(){
        int[] dimensions = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int R = dimensions[0];
        int Zr = dimensions[2];
        int Zc = dimensions[3];
        List<StringBuilder> lines = new List<StringBuilder>();
        for(int i = 0; i < R; i++)
        {
            // get original lines
            string original = Console.ReadLine();
            
            // foreach character
            for(int j = 0; j < Zr; j++)
            {
                var sb = new StringBuilder();
                lines.Add(sb);
                for(int k = 0; k < original.Length; k++)
                {
                    for(int n = 0; n < Zc; n++)
                    {
                        sb.Append(original[k]);
                    }
                }
            }
        }
        foreach(var line in lines){
            Console.WriteLine(line.ToString());
        }
    }
}