// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

void IsWeekend(int number)
{  
    if(number == 6 || number == 7)
    {
    Console.WriteLine("да");
    }
    else
    {
    Console.WriteLine("нет");
    }
}
Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);
IsWeekend(number);