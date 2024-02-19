//excersie4.4-https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
//https://app.codility.com/demo/results/trainingFFZ3H8-XNN/
using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        // if all nubers are unique max number could be lenght of array
        // if all number exist =>n+1
        // if all number negative =>1
        // else smalles miss number
        // brute force
        if(A.Length<=0)
        {
            return 1;
        }
       var allowedNumber=new HashSet<int>();
       for(int i=0;i<A.Length;i++)
       {
           allowedNumber.Add(A[i]);
       }

       for(int i=1;i<=A.Length;i++)
       {
           if(!allowedNumber.Contains(i))
           {
               return i;
           }
       }

       return A.Length+1;
    }
}