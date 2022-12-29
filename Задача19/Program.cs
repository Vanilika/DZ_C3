// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());

if (number > 99999)
{
    Console.WriteLine("Ошибка! Введите пятизначное число");
    return;
}

int firstNumber = number / 10000;
int secondNumber = number % 10000 / 1000;
int thirdNumber = number % 1000 / 100;
int fourNumber = number % 100 /10;
int fiveNumber = number % 10;

if(firstNumber = fiveNumber && secondNumber = fourNumber)
{
    Console.WriteLine($"{number}"+"- является палиндромом");
    return;
}
else
{
    Console.WriteLine($"{number}"+"- не является палиндромом");
    return;
}