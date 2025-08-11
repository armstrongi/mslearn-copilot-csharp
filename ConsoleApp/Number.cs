namespace ConsoleApp
{

    public class Number
    {
        // This class can be used to encapsulate number-related functionalities
        static public int Add(int a, int b)
        {
            return a + b;
        }

        // Write a function to check if a number is prime
        static public bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Write a function to add prime numbers in a numeric list
        static public int AddPrimeNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (Number.IsPrime(number))
                {
                    sum += number;
                }
            }
            return sum;
        }   
    }
}