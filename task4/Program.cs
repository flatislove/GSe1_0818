Console.Clear();
int number = 0;
int start = 1;
Console.WriteLine("Введите число");
try
{
    number = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Некорректное значение");
    Environment.Exit(0);
}
if (number > 0 && number != 1)
{

    while (start <= number)
    {
        if (start % 2 == 0)
        {
            Console.Write(start + ",");
        }
        start++;
    }
    Console.WriteLine();
}
else if (number < 0 && number != 1)
{
    while (start >= number)
    {
        if (start % 2 == 0)
        {
            Console.Write(start + "  ");
        }
        start--;
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("Четные числа в диапазоне отсутствуют");
}
