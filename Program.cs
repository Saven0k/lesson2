// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите цифру");
int a = int.Parse(Console.ReadLine());
if((a == 6) | ( a == 7)) 
{
    Console.WriteLine("Этот день являеться выходным");
    if (a == 6) Console.WriteLine("И это суббота");
    if (a == 7) Console.WriteLine("И это воскресенье");
}
else Console.WriteLine("Этот день не являеться выходным");