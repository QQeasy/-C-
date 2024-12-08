/*Задача 68: Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
Console.Clear();

Console.WriteLine("Программа вычисляет функцию Аккермана.");
Console.WriteLine();
Console.WriteLine("Введите два числа для вычисления функции Аккермана");
int m = ReadInt("Задайте неотрицательное число m: ");
if (m < 0)
{
    m = СhangeNum(m);
}
int n = ReadInt("Задайте неотрицательное число n: ");
if (n < 0)
{
    n = СhangeNum(n);
}
int result = 0;
int ack = AckermannFunc(m, n);
Console.Write($"Функция Аккермана при m = {m} и n = {n} равняется {ack}.");

int AckermannFunc(int i, int x)
{
    if (i == 0)
    {
        return x + 1;
    } 
    else if (x == 0) 
    {
        return AckermannFunc(i - 1, 1);
    }
    else 
    {
        return AckermannFunc(i - 1, AckermannFunc(i, x - 1));
    }
}

int СhangeNum(int a)
{

    Console.WriteLine($"Введенное число {a} является отрицательным!");
    string userInput = ReadString($"Для вычисления функции Аккермана введите другое число вместо {a}: ");
    a = ReadInt("Введите НЕОТРИЦАТЕЛЬНОЕ число: ");
    return a;
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