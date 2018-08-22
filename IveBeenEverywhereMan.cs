// https://open.kattis.com/problems/everywhere
using System;
using System.Collections.Generic;
public class Solution{
    public static void Main(string[] args){
        int cases = int.Parse(Console.ReadLine());
        List<string> distinct = new List<string>();
        string line;
        for(int i = 0; i < cases; i++){
            int cities = int.Parse(Console.ReadLine());
            for(int j = 0; j < cities; j++){
                if((line=Console.ReadLine())!=null && !distinct.Contains(line)){
                    distinct.Add(line);
                }
            }
            Console.WriteLine(distinct.Count);
            distinct.Clear();
        }
    }
} 