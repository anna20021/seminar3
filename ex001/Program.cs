// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
Console.WriteLine("enter number");
int number = Convert.ToInt32(Console.ReadLine());
int a =0;
int b = 0;
int c = 0;
int d = 0;
int e = 0;
int number2 = 0;

a = number / 10000;
b = number / 1000;
b = b % 10;
c = number / 100;
c = c % 10;
d = number / 10;
d = d % 10;
e = number % 10;

number2 = e*10000+d*1000+c*100+b*10+a;

if (number2 = number)
{
    Console.WriteLine("palindrom");
}
else 
{
Console.WriteLine("not palindrom");
}

