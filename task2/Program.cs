Console.Clear();
int numberOne = 0;
int numberTwo = 0;
int numberThree = 0;
try
{

    Console.WriteLine("Введите первое число");
    numberOne = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    numberTwo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    numberThree = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Введите корректные значения");
    Environment.Exit(0);
}
if (numberOne >= numberTwo && numberOne >= numberThree)
{
    Console.Write("Максимальное - ");
    Console.WriteLine(numberOne);
}
else if (numberTwo >= numberOne && numberTwo >= numberThree)
{
    Console.Write("Максимальное - ");
    Console.WriteLine(numberTwo);
}
else if (numberThree >= numberOne && numberThree >= numberTwo)
{
    Console.Write("Максимальное - ");
    Console.WriteLine(numberThree);
}
