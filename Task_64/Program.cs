/*Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. Выполнить с 
помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"

N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Clear();


Console.WriteLine("Программа выводит все натуральные числа в промежутке от N до 1.");
Console.WriteLine();
int num = ReadInt("Введите число N: ");
Console.WriteLine();
if (num > 0)
{
    Console.WriteLine($"Ваша последовательность от {num} до 1: ");
    Console.WriteLine(ReverseSeqceOFnum(num));
}
else
{
    Console.WriteLine($"Введенное число {num} не является натуральным!");
    string userInput = ReadString("Введите '+' для того чтобы вывести справку: ");
    if (userInput == "+")
    {
        Console.WriteLine("Натуральные числа — это числа, которые возникают естественным способом при подсчёте.");
        Console.WriteLine("С их помощью можно определить количество любых предметов, их осязаемую последовательность.");
    }
}

int ReverseSeqceOFnum(int a)
{
    if (a == 1)
        return a;
    else
    {
        Console.Write(a + ", ");
        return a = ReverseSeqceOFnum(a - 1);
    }
}



string ReadString(string massage)
{
    Console.Write(massage);
    return Console.ReadLine();
}
int ReadInt(string massage)
{
    Console.Write(massage);
    return Convert.ToInt32(Console.ReadLine());
}