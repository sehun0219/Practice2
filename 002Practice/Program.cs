
//Description
//We need a function that can transform a string into a number. What ways of achieving this do you know?
//Note: Don 't worry, all inputs will be strings, and every string is a perfectly valid representation of an integral number.

// 문자열을 숫자로 바꾸는 함수 


using System;
public class Kata
{
    public static int StringToNumber(String str)
    {
        
        return Convert.ToInt32(str);
        //return (int.Parse(str));
    }
}
