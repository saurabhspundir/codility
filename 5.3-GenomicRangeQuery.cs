//https://app.codility.com/demo/results/trainingEQJFU4-TZV/
using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        // Implement your solution here
        // result array of len P.Length
        var result = new int[P.Length];
        //A=1,C=2,G=3,T=4 =>dnaKey
        // var dnaKey = new Dictionary<char,int>(){
        //     {'A',1},{'C',2},{'G',3},{'T',4},
        // };
        //1- go through S and keep track of all genome counts
        //1.1- to keep track we need array for A,C G,T
        //length 1 coz we need first one to be 0 so that we have base to make deduction later
        var A = new int[S.Length+1];
        var C = new int[S.Length+1];
        var G = new int[S.Length+1];
        var T = new int[S.Length+1];    
        for(int i=0;i<S.Length;i++)
        {
            // we copy previous value
            A[i+1]=A[i];
            C[i+1]=C[i];
            G[i+1]=G[i];
            T[i+1]=T[i];
            // increase by 1 based on what is current value
            
            switch(S[i]) 
            {
                case 'A':
                A[i+1]++;
                break;
                case 'C':
                C[i+1]++;
                break;
                case 'G':
                G[i+1]++;
                break;
                case 'T':
                T[i+1]++;
                break;
            } 
           
        }
   
        //2- go through P & Q and keep calculating diff and pick first with digit as it will belowest 
        for(int i=0;i<P.Length;i++)
        {
            var start=P[i];
            var end=Q[i];
            // we have to get value for all arrays at start & end
            var a=A[end+1]-A[start];//+1 coz we added extra 0 based 
            var c=C[end+1]-C[start];
            var g=G[end+1]-G[start];
            var t=T[end+1]-T[start];

            var minValue=1;
            if(a>0)
            {
               minValue=1;     
            }
            else if(c>0)
            {
                minValue=2;
            }
            else if(g>0)
            {
                minValue=3;
            }
            else if(t>0)
            {
                minValue=4;
            }

            //3- get key with min value , add to result
            result[i]=minValue;
        }
        return result;
    }
}