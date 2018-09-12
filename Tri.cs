// https://open.kattis.com/problems/tri
// Steve Jia
using System;
public class Solution{
    public static void Main(){
        string[] symbols = new string[]{"+", "-", "*", "/"};
        Func<int, int, int>[] operations = {
            (x, y) => x + y,
            (x, y) => x - y,
            (x, y) => x * y,
            (x, y) => x / y
        };
        
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        
        for(int i = 0; i < operations.Length; i++){
            if(operations[i](inputs[0], inputs[1]) == inputs[2]){
                Console.WriteLine($"{inputs[0]}{symbols[i]}{inputs[1]}={inputs[2]}");
                break;
            }
            else if(operations[i](inputs[1], inputs[2]) == inputs[0]){
                Console.WriteLine($"{inputs[0]}={inputs[1]}{symbols[i]}{inputs[2]}");
                break;
            }
        }
    }
}