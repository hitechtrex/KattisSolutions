// https://open.kattis.com/problems/deathknight
// Steve Jia

using System;
using System.Collections.Generic;
using System.Linq;
public class Solution{
    public static void Main(){
        int battles = int.Parse(Console.ReadLine());
        List<string> abilities = new List<string>();
        for(int i = 0; i < battles; i++){
            abilities.Add(Console.ReadLine());
        }
        Console.WriteLine(abilities.Where(x => !x.Contains("CD")).Count());
    }
}