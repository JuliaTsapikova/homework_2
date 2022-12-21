// Задача 10. Написать программу, которая на вход принимает трехзначное число
// и на выходе показывает вторую цифру этого числа.

int GetSecondDigit(int number)
{
    int number1 = number / 10;
    int number2 = number1 % 10;
    return number2;
}

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Вторая цифра трехзначного числа равна {GetSecondDigit(number)}");