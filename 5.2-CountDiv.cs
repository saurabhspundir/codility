//lessaon5.2:https://app.codility.com/programmers/lessons/5-prefix_sums/count_div/
//https://app.codility.com/demo/results/trainingRVYR4K-QKY/
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        // Implement your solution here
        // 1- reminder=divide A%K 
        
        
        var firstNumber=Math.Floor((double)A/K);// 1.2 else A is first number
        
        var reminder=firstNumber%K;
        
        var lastNumber=Math.Floor((double)B/K);

        //2 from first number every kth number 
        // B-first number/K+1
        return (int)(lastNumber-firstNumber+(A%K==0?1:0));
    }
}
