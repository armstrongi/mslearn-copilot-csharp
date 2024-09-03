// See https://aka.ms/new-console-template for more information

int add(int a, int b)
{
    return a + b;
}

// Write a function to add prime numbers in a numeric list
int addPrimeNumbers(List<int> numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        if (isPrime(number))
        {
            sum += number;
        }
    }
    return sum;
}

// Write a function to check if a number is prime
bool isPrime(int number)
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

int x = add(2, 3);
Console.WriteLine(x.ToString());

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

int y = addPrimeNumbers(numbers);
Console.WriteLine(y.ToString());



