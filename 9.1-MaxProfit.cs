//excercise9.2-https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_profit/
//https://app.codility.com/demo/results/trainingU85ABZ-J2W/
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        if(A.Length==0)
        {
            return 0;
        }

        int highest=0;
        int lowest=int.MaxValue;
        int profit=0;
        //1- go through loop
        for(int i=0;i<A.Length;i++)
        {
            lowest =Math.Min(lowest,A[i]);
            if(A[i]<highest)
            {
                highest=0;
            }
            else
            {
                highest=Math.Max(highest,A[i]);
                profit=Math.Max(profit,A[i]-lowest);
            }
        }

        return profit;

        // keep track of highest & lowest. but highest can get reset when lower number current<highest

    }
}