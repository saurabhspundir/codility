//excercise 9.2-https://app.codility.com/programmers/lessons/9-maximum_slice_problem/max_slice_sum/
// /https://app.codility.com/demo/results/trainingXDWTRE-2UM/
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int maxSum = int.MinValue;
        int localSum = 0;
        for (int i = 0; i < A.Length; i++) {
            localSum = Math.Max(localSum + A[i], A[i]);
            maxSum   = Math.Max(localSum, maxSum);
        }
        return maxSum;
    }
}