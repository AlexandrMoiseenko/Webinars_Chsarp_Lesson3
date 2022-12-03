// Напишите программму, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

int Hello(string message)                           // Метод вывода приглашения и ввода числа
{
    Console.Write(message + " >");                  // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());     // Ввод числа
}

int x1 = Hello("Введите х1: ");                     // Ввод первой точки
int y1 = Hello("Введите y1: ");
int z1 = Hello("Введите z1: ");

int x2 = Hello("Введите х2: ");                     // Ввод второй точки
int y2 = Hello("Введите y2: ");
int z2 = Hello("Введите z2: ");

int X = x2 - x1;
int Y = y2 - y1;
int Z = z2 - z1;

double distance = Math.Sqrt(X*X + Y*Y + Z*Z);
Console.WriteLine("Расстояние в 3D-пространстве равно " + distance);