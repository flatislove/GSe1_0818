Console.Clear();
int number = 0;
Console.WriteLine("Введите число");
try
{
    number = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Введите корректное значение");
    Environment.Exit(0);
}
if (number % 2 == 0)
{
    Console.Write("Число является четным - ");
    Console.WriteLine(number);
}
else
{
    Console.Write("Число не является четным - ");
    Console.WriteLine(number);
}

