// https://open.kattis.com/problems/drmmessages
// Steve Jia

using System;
using System.Linq;
using System.Text;
public class Solution{
    public static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();

        int diff = (int)'A';
        int rValue1 = input.Take(input.Length / 2).Sum(x => x-diff);
        int rValue2 = input.Skip(input.Length / 2).Sum(x => x-diff);

        for (int i = 0; i < input.Length; i++)
        {
            input[i] = GetNext(input[i], (i < input.Length / 2) ? rValue1 : rValue2);
        }
        //Console.WriteLine(input);

        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < input.Length/2; i++)
        {
            sb.Append(GetNext(input[i], input[i + input.Length / 2]));
        }
        Console.WriteLine(sb.ToString());
    }

    static char GetNext(char original, int forward)
    {
        int newChar = 'A' + ((forward - ('Z' + 1 - original)) % 26);
        return (char)newChar;
    }

    static char GetNext(char original, char forward)
    {
        int newChar = 'A' + ((forward - ('Z' + 1 - original - 'A')) % 26);
        return (char)newChar;
    }
}