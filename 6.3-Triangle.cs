//https://app.codility.com/programmers/lessons/6-sorting/triangle/
//https://app.codility.com/demo/results/training6YV2B7-YYY/

using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        if(A.Length<3)
        {
            return 0;
        }
        //reason for sorting is that it statisfy below 2 conditions and we have to only validate A[P] + A[Q] > A[R].
        // A[Q] + A[R] > A[P],
        // A[R] + A[P] > A[Q].
        Array.Sort(A);

          for(int i=2; i< A.Length; i++){
            if((long)A[i-2] + (long)A[i-1] > (long)A[i]) // note: using "long" for overflow cases
            {
                return 1; 
            }
            // note: we just need one combination
        }
        return 0;
    }
}