//lessopn3.-1:https://app.codility.com/programmers/lessons/3-time_complexity/frog_jmp/
//https://app.codility.com/demo/results/training2ZM7RD-QUV/
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
        // Implement your solution here
        return (int)Math.Abs(Math.Ceiling((((decimal)Y-X)/D)));

        // another soultion
        // int numberOfSteps=0;
        // int currentPosition=X;
        // while(currentPosition<Y)
        // {
        //     currentPosition+=D;
        //     numberOfSteps++;
        // }

        // return numberOfSteps;
    }
}