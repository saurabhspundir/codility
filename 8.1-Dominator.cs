//excercise8.2-https://app.codility.com/programmers/lessons/8-leader/dominator/
// /https://app.codility.com/demo/results/training7X4GWU-998/
using System;
// you can also use other imports, for example:
 using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        if(A.Length==0)
        {
            return -1;
        }
        
        var middle =A.Length/2;
        var counter = new Dictionary<int,int>();
        for(int i=0;i<A.Length;i++)
        {
            if(counter.ContainsKey(A[i]))
            {
               counter[A[i]] ++;
            }
            else
            {
                counter.Add(A[i],1);
            }
            if(counter[A[i]]>middle)
            {
                return i;
            }

        }
        return -1;
    }
}