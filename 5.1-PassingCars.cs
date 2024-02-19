//lesson5.1-https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
//https://app.codility.com/demo/results/trainingUBN95B-FGE/
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        //collection on how many 0's(East)
        int east=0;
        //every time we get west we add 
        int passed=0;
        for(int i=-0;i<A.Length;i++)
        {
            if(A[i]==0)
            {
                east++;
            }
            else
            {
                passed+=east;
            }

        }
        return passed>1000_000_000||passed<0?-1:passed;

    }
}