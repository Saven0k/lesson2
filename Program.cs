// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string numberend = Convert.ToString(number);
if (numberend.Length > 2)
{
  Console.WriteLine("третья цифра -> " + numberend[2]);
}
else 
{
  Console.WriteLine($"{number} -> третьей цифры нет");
}