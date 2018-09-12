// https://open.kattis.com/problems/sodasurpler
// Steve Jia
using System;
public class Solution{
    static int numSoda=0, emptyToNew = 0;
    public static void Main()
    {
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int numEmpty = inputs[0] + inputs[1];
        emptyToNew = inputs[2];
        BuyNewSodaRecursive(numEmpty);
        Console.WriteLine(numSoda);
    }
    
    static void BuyNewSodaRecursive(int numEmpties){
        if(numEmpties < emptyToNew) return;
        int numNewSodas = numEmpties / emptyToNew;
        int leftOverEmpties = numEmpties % emptyToNew;
        numSoda += numNewSodas;
        BuyNewSodaRecursive(numNewSodas + leftOverEmpties);
    }
} 