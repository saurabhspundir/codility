//excercise7.2-https://app.codility.com/programmers/lessons/7-stacks_and_queues/fish/
//https://app.codility.com/demo/results/training5MYB3S-X6K/
using System;
// you can also use other imports, for example:
using System.Collections;
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // Implement your solution here
       // we have to store upstream(0)  downstream(1) in stacks
        var downstreamStack= new Stack<int>();
        int eaten=0;
        //1- we have to loop through B 
        for(int i=0;i<B.Length;i++)
        {
            //downstream
            if(B[i]==1)
            {
                downstreamStack.Push(A[i]);
            }
            else//upstream
            {
                while(downstreamStack.Count>0)
                {
                    var downstream= downstreamStack.Peek();
                    //upstreamstream bigger
                    if (downstream<A[i])
                    {
                        downstreamStack.Pop();
                        eaten++;
                    }
                    else
                    {
                        eaten++;
                        break;
                    }
                }
            }
        }
       //2 count pending 
        return B.Length-eaten;
    }
}