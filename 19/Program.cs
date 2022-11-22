// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

bool Palindrome (int num)
{
    return num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10;
}
if (number > 9999 && number < 100000)
{
bool res = Palindrome(number);
Console.WriteLine(res ? "Да" : "Нет");
}
else
Console.WriteLine("Ошибка! Введино не пятизначное число!");