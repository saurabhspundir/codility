//excercise4.1- https://app.codility.com/programmers/lessons/4-counting_elements/frog_river_one/
//https://app.codility.com/demo/results/trainingE9E6AC-FPC/
using System;
using System.Collections;
// you can also use other imports, for example:
 using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        // Implement your solution here
        // find what index do we have 1...X all available
        // when we get X but also all before X
        //1- Hashset/dic with keys 1..X => path
        // var path = new Dictionary<int, int>();
        // for(int i=0;i<=X;i++)
        // {
        //     path.Add(i,0);
        // }
        var path = new HashSet<int>();
         for(int i=1; i<= X; i++){
            path.Add(i);
        }

        //2- a max step when i found 1..X
        //3- loop through A
        for(int i=0;i<A.Length;i++)
        {
            if(path.Contains(A[i]))
            {
                path.Remove(A[i]);
            }
            if(path.Count<=0)
            {
                return i;
            }
        }
        return -1;


        //3.1 if we have any key from path, get index  , comapre with max and store
        //3.2 short circuit- if we find all keys have value, exit.
    }
}