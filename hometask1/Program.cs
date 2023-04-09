// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadInt(string massage)
{
    System.Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}
int GetRange(int number)
{
    int a = number / 10000;
    int b = (number / 1000) % 10;
    int c = (number / 100) % 10;
    int d = (number / 10) % 10;
    int e = number % 10;

    if (a == e && b == d)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
    return 0;
}


int value = ReadInt("Введите пятизначное число");
int a = GetRange(value);
Console.WriteLine(a);