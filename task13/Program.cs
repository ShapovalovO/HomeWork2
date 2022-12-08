//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

string chr = Convert.ToString(num);
if(num > 99)
{
    Console.WriteLine($"{chr[2]}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}