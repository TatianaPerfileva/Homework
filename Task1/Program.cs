int numberOne = new Random().Next(-100, 100);
Console.WriteLine(numberOne);
int numberSecond = new Random().Next(-100, 100);
Console.WriteLine(numberSecond);

if (numberOne > numberSecond)
{
    Console.Write("max ");
    Console.WriteLine(numberOne);
    Console.Write("min ");
    Console.WriteLine(numberSecond);
}
else
{
    Console.Write("max ");
    Console.WriteLine(numberSecond);
    Console.Write("min ");
    Console.WriteLine(numberOne);
}