// https://open.kattis.com/problems/symmetricorder
// Steve Jia
using System;
public class Solution{
    public static void Main(){
        int setNum = 1;
        while(true){
            int numPeople = int.Parse(Console.ReadLine());
            if(numPeople == 0) break;
            string[] sorted = new string[numPeople];
            int j = 0, k = numPeople-1;
            for(int i = 0; i < numPeople; i++){
                string name = Console.ReadLine();
                if(i%2 == 0){
                    sorted[j] = name;
                    j++;
                }
                else if (i%2 == 1){
                    sorted[k] = name;
                    k--;
                }
            }
            
            Console.WriteLine($"SET {setNum}");
            foreach(string name in sorted){
                Console.WriteLine(name);
            }
            setNum++;
        }
    }
}