// https://open.kattis.com/problems/encodedmessage
// Steve Jia

using System;
using System.Text;
public class Solution{
    public static void Main(){
        int testCases = int.Parse(Console.ReadLine());
        for(int i = 0; i < testCases; i++){
            string secret = Console.ReadLine();
            int size = Convert.ToInt32(Math.Sqrt(secret.Length));
            char[,] grid = new char[size,size];
            for(int j = 0; j < secret.Length; j++){
                grid[j/size, j%size] = secret[j];
            }
            //Console.WriteLine(grid);
            StringBuilder sb = new StringBuilder();
            for(int k = size-1; k >= 0; k--){
                for(int m = 0; m < size; m++){
                    sb.Append(grid[m, k]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}