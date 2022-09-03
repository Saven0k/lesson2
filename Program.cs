//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
int a = new Random().Next(100 , 1000);
int b = a / 10;
int c = a / 100;
int progress = a - (b * 10);
int result = c * 10 + progress;
Console.WriteLine($"{a} - > {result}");
