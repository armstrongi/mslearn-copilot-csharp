// See https://aka.ms/new-console-template for more information
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Number.Add(2, 3);
            Console.WriteLine("Number.Add(2, 3) = " + x.ToString());
            
            // Create a list of 100 random numbers between 1 and 1000
            List<int> numbers = new List<int>();
            Random random = new Random();
            
            for (int i = 0; i < 100; i++)
            {
                int randomNumber;
                do
                {
                    randomNumber = random.Next(1, 1000);
                } while (numbers.Contains(randomNumber));

                numbers.Add(randomNumber);
            }

            int y = Number.AddPrimeNumbers(numbers);
            Console.WriteLine("Sum of prime numbers = " + y.ToString());
        }             
    }
}



