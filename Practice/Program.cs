//Write a function that takes an array of numbers and returns the sum of the numbers.
//The numbers can be negative or non-integer.
//If the array does not contain any numbers then you should return 0.

// 배열의 숫자의 합을 구하는 함수
// 원소들은 음수거나 실수가 가능하다.
// 배열이 원소를 갖고있지 않으면 0을 리턴한다.

public class Kata
{
    public static double SumArray(double[] array)
    {
        double sum = 0;
        if (array.Length == 0)
        {
            return 0;
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i] ;
            }
        }
        
        return sum;
    }

    static void Main(string[] args)
    {
        double[] array = new double[4];
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;

        SumArray(array);
    }
}