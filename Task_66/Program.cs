/*Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N. Выполнить 
с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

Console.WriteLine("Программа находит сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine();
int sum = 0;
int m = ReadInt("Задайте начальное число M: ");
if (m < 0)
{
    NoNaturalNum(m);
}
else
{
    int n = ReadInt("Задайте конечное число N: ");
    if (n < 0)
    {
    NoNaturalNum(n);
    }
    else
    {
        if (m <= n)
        {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равняется {SequenceOFnum(m, n)}");
        }

    else
    {
        Console.WriteLine($"Введенный начальный элемент {m} больше конечного элемента {n}!");
        string userInput = ReadString($"Введите '+' если хотите запустить подсчет суммы натуральных элементов в промежутке от {n} до {m}: ");
        if (userInput == "+")
        {
            Console.WriteLine($"Сумма натуральных элементов в промежутке от {n} до {m} равняется {SequenceOFnum(n, m)}.");
        }
    }
    }

}


void NoNaturalNum(int a)
{
    if (a < 0)
    {
        Console.WriteLine($"Введенное число {a} не является натуральным!");
        Console.WriteLine();
        string userInput = ReadString("Введите '+' для того чтобы вывести справку: ");
        if (userInput == "+")
        {
            Console.WriteLine("Натуральные числа — это числа, которые возникают естественным способом при подсчёте.");
            Console.WriteLine("С их помощью можно определить количество любых предметов, их осязаемую последовательность.");
        }
    }
}





int SequenceOFnum(int a, int b)
{
    if (a > b)
        return sum;
    else
    {
        sum += b;
        return b = SequenceOFnum(a, b - 1);
    }
}



string ReadString(string massage)
{
    Console.Write(massage);
    return Console.ReadLine();
}

int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());
}