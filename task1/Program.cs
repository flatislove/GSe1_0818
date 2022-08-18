Console.Clear();
int numberOne = 0;
int numberTwo = 0;

try
{
    Console.WriteLine("Введите первое число");
    numberOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    numberTwo = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Введите корректные значения");
    Environment.Exit(0);
}
if (numberOne > numberTwo)
{
    Console.Write("Большее - ");
    Console.WriteLine(numberOne);
    Console.Write("Меньшее - ");
    Console.WriteLine(numberTwo);
}
else if (numberOne < numberTwo)
{
    Console.Write("Большее - ");
    Console.WriteLine(numberTwo);
    Console.Write("Меньшее - ");
    Console.WriteLine(numberOne);
}
else if (numberOne == numberTwo)
{
    Console.Write(numberOne);
    Console.Write(" равно ");
    Console.WriteLine(numberTwo);
}