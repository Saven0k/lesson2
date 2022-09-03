// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число");
string[] number = Console.ReadLine().Split(' ');
Console.WriteLine(number)
;

// int a = int.Parse(number[2]);
// int b = number.Length();
// Console.WriteLine($"{number} -> {number[1]}");


// if((a == 0) | (a == 1) | (a == 2) | (a == 3) | (a == 4) | (a == 5) | (a== 6) | (a == 7) | (a == 8) |(a == 9)) 
// {
//     Console.WriteLine($"{number} ->   {number[2]} ");
// }
// else Console.WriteLine($"{number} -> третьей цифры нет");

// if(a == " ") Console.WriteLine($"{number} -> третьей цифры нет");
// else Console.WriteLine($"{number} ->   {a} ");
