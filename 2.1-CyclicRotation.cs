//Lession2.1- https://app.codility.com/programmers/lessons/2-arrays/cyclic_rotation/
//https://app.codility.com/demo/results/trainingE3EKTX-G9Y/
using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // Implement your solution here
        //1: loop it K time
        for(int i=0;i<K;i++)
        {
            A=AdjustArray(A);
        }
        //2: new array = A[N-1], A[1,N-2]
        return A;
    }

    private int[] AdjustArray(int[] input)
    {
        int arrayLength=input.Length;
        int[] b= new int[arrayLength];
        b[0]=input[arrayLength-1];
        input.Take(arrayLength-1).ToArray().CopyTo(b,1);
        return b;
    }
}