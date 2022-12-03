// Напишите программу, которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 42824 -> да

int Hello(string message)                           // Метод вывода приглашения и ввода числа
{
    Console.Write(message + " >");                  // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine());     // Ввод числа
}

int number = Hello("Введите пятизначное число: ");              // Ввод числа

int N1 = number/10000;
int N2 = number%10;
int n3 = number/1000;
int N4 = n3%10;
int n5 = number%100;
int N6 = n5/10;

if(N1 == N2 && N4 == N6)
{
    Console.WriteLine("Да, является палиндромом");
}
else
{
    Console.WriteLine("Нет, не является палиндромом");
}