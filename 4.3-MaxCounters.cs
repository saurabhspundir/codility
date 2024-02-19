//excercise 4.3- https://app.codility.com/programmers/lessons/4-counting_elements/max_counters/
//https://app.codility.com/demo/results/training9S892T-DR7/
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        // Implement your solution here
        //1: array result[] for length N
       // 1. key point: maintain the max value
        int max = 0;
        
        // 2. key point: maintain the current_min (very important!!!)
        // so, we can move "the 2nd for-loop" outside "the 1st for-loop" 
        // by maintaining "min"
        int min =0;
        
        // new integer array
        int[] my_array = new int[N]; 
        
        for(int i=0; i<A.Length; i++){
            if( A[i] >= 1 && A[i] <= N){ // normal case
            
                // important: check the "min" before "increasing by 1"
                if(my_array[ A[i] -1] < min){
                    my_array[ A[i] -1] = min; // update it to "min"
                }
                
                my_array[ A[i] -1 ] ++;  // increased by 1
                
                if( my_array[ A[i] -1 ] > max){ // maintain max
                    max = my_array[ A[i] -1 ];
                }
            }
            else if( A[i] == N+1){      // special case 

                min = max; // all the values should be bigger than "max"
                           // therefore, "min = max"
            }
        }
        
        // move the 2nd for-loop outside the 1st for-loop
        // update some elements who have not been updated yet
        for(int j=0; j<my_array.Length; j++){
            if(my_array[j] < min){
                my_array[j] = min; // update it to "min"
            }
        }
        
        return my_array;
    }
}