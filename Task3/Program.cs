int number = new Random().Next(-100, 100);
//Console.WriteLine(number);
if (number % 2 == 0)
    {
        Console.WriteLine($"{number} -четное число");
    }
else
    {
    Console.WriteLine($"{number}-нечетное число");
    }