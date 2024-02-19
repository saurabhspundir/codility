//excercisee6.3-https://app.codility.com/programmers/lessons/6-sorting/max_product_of_three/
// /https://app.codility.com/demo/results/training8BGYV6-9HH/

using System;
// you can also use other imports, for example:
 using System.Collections;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        Array.Sort<int>(A);
        int length=A.Length;
        // Check min 2 digit coz if they are negative but higher number there multiplcation can still be + 
        return Math.Max((A[length-1]*A[length-2]*A[length-3]),(A[0]*A[1]*A[length-1]));
    }
}