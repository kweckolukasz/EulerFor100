﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class E1_MultiplesOf3And5
    {
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        //Find the sum of all the multiples of 3 or 5 below 1000.

       public int SumOfNumbers;

       public void Solution()
        {
            for (int i = 2; i < 1000; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    SumOfNumbers += i;
                }
            }
        }
        

    }
}
