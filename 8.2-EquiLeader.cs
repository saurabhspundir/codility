//excercise8.2-https://app.codility.com/programmers/lessons/8-leader/equi_leader/
//https://app.codility.com/demo/results/training4BUGYA-43Y/
using System;
// you can also use other imports, for example:
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int midLength =A.Length/2;
        var leaderCounter=new int[A.Length];
        int leaderCount=0;
        var elementCounter = new Dictionary<int, int>();
        int leader=-100_000_001;
        //1- first we find leader
        for(int i=0;i<A.Length;i++)
        {
            if(elementCounter.ContainsKey(A[i]))
            {
                elementCounter[A[i]]++;
            }
            else
            {
                elementCounter.Add(A[i],1);
            }
            if(elementCounter[A[i]]>midLength)
            {
                leader=A[i];
                leaderCount=elementCounter[A[i]];
                //break;    
            }
        }

        //2- we keep track of count of leader in array B
        var previousSum=0;
        // for(int i=0;i<leaderCounter.Length;i++)
        // {
        //     if(A[i]==leader)
        //     {
        //        previousSum++;     
        //     }
        //     leaderCounter[i]=previousSum;
        // }
        int counter=0;
        // A =[4,3,4,4,4,2]
        // lS =[1,1,2,3,4,4] 
        // [1,1,2][3,4,4] 
        // [1,1][2,3,4,4] 
        //3- go through array B and slice  
        
        //once reached half length no need to go further 
        for(int i=0;i<leaderCounter.Length;i++)
        {
             if(A[i]==leader)
            {
               previousSum++;     
            }
          //3.1: slice at i
          //3.2: Length of 2 arrays 
          int leftArrayLength=leaderCounter.Take(i+1).Count();
          int rightArrayLength=leaderCounter.Skip(i+1).Count();
          //3.1- if count is greater on both side that counter ++;
          if(previousSum>leftArrayLength/2 && (leaderCount-previousSum)>rightArrayLength/2)
          {
                counter++;
          }
        }
        
        //4 return counter
        return counter;
    }
}