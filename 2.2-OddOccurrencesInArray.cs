//Lesson2.2-https://app.codility.com/programmers/lessons/2-arrays/odd_occurrences_in_array/
https://app.codility.com/demo/results/trainingSMDNND-DA8/
using System;
using System.Collections;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        HashSet<int> keys = new HashSet<int>();

        foreach(int a in A) 
        {
            if(keys.Contains(a))
            {
                keys.Remove(a);
            }
            else
            {
                keys.Add(a);
            }
        }
        
        return keys.Count>0? keys.First():0;

    }
}