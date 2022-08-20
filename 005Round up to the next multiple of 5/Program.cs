﻿//DESCRIPTION:
//Given an integer as input, can you round it to the next (meaning, "greater than or equal") multiple of 5?

//Examples:

//input: output:
//0->   0
//2->   5
//3->   5
//12->   15
//21->   25
//30->   30
//- 2->   0
//- 5->   - 5
//etc.
//Input may be any positive or negative integer (including 0).

//You can assume that all inputs are valid integers.


public class Kata
{
    public static int RoundToNext5(int n)
    {
        while (n % 5 != 0)
        {
           n++;
        }
        return n;
    }

    static void Main(string[] args)
    {
        RoundToNext5(0);
        RoundToNext5(1);
        RoundToNext5(5);
        RoundToNext5(87);
        RoundToNext5(43);
        RoundToNext5(222);
    }
}