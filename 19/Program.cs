//Напишите программу, которая принимает 
//на вход пятизначное число и проверяет, является ли 
//оно палиндромом.

Console.Clear();
Console.Write("ВВедите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int num = number;
int rev = 0;

if (number <10000 || number > 99999)
{
    Console.WriteLine("Введено не правильное число");
    return;
}
while (number > 0)
{
    int i = number % 10;
    rev = rev * 10 + i;
    number = number / 10;
}
if (num == rev)
{
    Console.WriteLine("Это палиндром! ");
} else
{
    Console.WriteLine("Это не палиндром! ");
}