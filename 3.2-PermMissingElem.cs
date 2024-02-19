//Lesson3.2-https://app.codility.com/programmers/lessons/3-time_complexity/perm_missing_elem/
//https://app.codility.com/demo/results/trainingRKQEGP-2TQ/
//80% only
using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        ulong sumofArray= 0;
        int length=A.Length+1;
        ulong sumOfN= (ulong)(length*(length+1))/2;
        for(int i=0;i<A.Length;i++)
        {
            sumofArray+=(ulong)A[i];
        }
        ulong result=sumOfN-sumofArray;
        return (int)result;
    }
}