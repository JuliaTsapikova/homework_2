// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

void GetThirdDigit(double number)
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (number > 999)
			{
				number = Math.Truncate(number/10);
			}
			
		double delta = number - Math.Truncate(number/10)*10;
        Console.WriteLine($"Ответ: {delta}");
    }
		
}
Console.Write("Введите число: ");
double number = double.Parse(Console.ReadLine()!);
GetThirdDigit(number);