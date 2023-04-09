// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.

int ReadInt(string massage)
{
    System.Console.Write($"{massage} >");
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = ReadInt("Введите первую точку координата х");
int y1 = ReadInt("Введите первую точку координата у");
int z1 = ReadInt("Введите первую точку координата z");
int x2 = ReadInt("Введите вторую точку координата х");
int y2 = ReadInt("Введите вторую точку координата у");
int z2 = ReadInt("Введите вторую точку координата z");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между точками" +distance);
