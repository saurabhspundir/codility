//excercise 4.2-https://app.codility.com/programmers/lessons/4-counting_elements/perm_check/
//https://app.codility.com/demo/results/trainingBPCDGC-CZX/
using System;
// you can also use other imports, for example:
using System.Collections;
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        // array length is max number we looking for 
        // hashset with 1..N
        // loop through A and see if all hashset elements present

        var elements = new HashSet<int>();
        for(int i=1;i<=A.Length;i++)
        {
             elements.Add(i); 
        }

        for(int i=0;i<A.Length;i++)
        {
            if(elements.Contains(A[i]))
            {
                elements.Remove(A[i]);
            }
        }

        return elements.Count>0?0:1;

    }
}