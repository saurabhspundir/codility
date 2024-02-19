//excercise7.4-https://app.codility.com/programmers/lessons/7-stacks_and_queues/stone_wall/
//https://app.codility.com/programmers/lessons/7-stacks_and_queues/stone_wall/
using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] H) {
        if(H.Length<=0)
        {
            return 0;
        }
        // Implement your solution here
        int numberOfStones=0;
        var lastStoneAfterPeak=new Stack<int>();
        
        for(int i=0;i<H.Length;i++)
        {
            while(lastStoneAfterPeak.Count>0 && lastStoneAfterPeak.Peek()>H[i])
            {
                lastStoneAfterPeak.Pop();
            }
            //1- we get H[i]
            //2- compare H[i] with previous height
            // 2.1 - if H[i]==height--> no stone
            // 2.2 - if H[i]<height --> new stone       
            if(lastStoneAfterPeak.Count<=0) 
            {
                lastStoneAfterPeak.Push(H[i]);
                numberOfStones++;
            }
            else if(lastStoneAfterPeak.Peek()==H[i])
            {
                // do nothing
            }
            else if(lastStoneAfterPeak.Peek()<H[i])
            {
                 lastStoneAfterPeak.Push(H[i]);
                numberOfStones++;
            }
        }
        return numberOfStones;
    }
}