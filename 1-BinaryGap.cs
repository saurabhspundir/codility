//Lesson1- https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
//https://app.codility.com/demo/results/trainingRN7PS5-383/
using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // Implement your solution here
        //1 : wE CONVERt the N to binary-> string
        string binary = Convert.ToString(N, 2);
        //1.1: 2 variables for tracking length, keeping max length
        int maxLength=0, currentLength=0;

        //2: we iterate throught that string to find gap
        foreach(var bit in binary)
        {
             //2.2 : first always 1(observation)
            if(bit=='1' && currentLength==0)
            {
                continue;
            }

            if(bit=='0' )
            {
                currentLength++;
            }
            else // we encounterd 1//2.3 : start counter untill find next 1-> current length
            {
                //2.4: if current length>max length -> maxlength=current length
                if(maxLength<currentLength)
                {
                    maxLength=currentLength;
                }
                currentLength=0;//reset the length
            }
        }
        return maxLength;
        //edge case: where only one 1 ,so we have to return 0
        // if out of loop &  max length is 0 it means never updated
    }
}
