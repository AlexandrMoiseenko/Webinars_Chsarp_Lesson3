// Напишите программу, которая принимает на вход (N) число и
// выдает таблицу кубов чисел от 1 до N. Например:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Hello(string message)                           // Метод вывода приглашения и ввода числа
{
    Console.Write(message + "> ");                  // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());     // Ввод числа
}

int number = Hello("Введите число ");

int count = 0;

while(count <= number)
{
    int cubecount = count * count * count;
    Console.Write(cubecount + " ");
    count++;
}