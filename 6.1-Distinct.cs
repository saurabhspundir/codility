//excercise6.1-https://app.codility.com/programmers/lessons/6-sorting/distinct/
// https://app.codility.com/demo/results/training8DRF23-263/
using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        var keys = new HashSet<int>();
        for(int i=0;i<A.Length;i++)
        {
            if(!keys.Contains(A[i]))
            {
                keys.Add(A[i]);
            }
        }

        return keys.Count;
    }
}