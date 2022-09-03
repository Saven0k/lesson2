// 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да
Console.Clear();
Console.WriteLine("Введите  число: ");
int a = int.Parse( s :Console.ReadLine());
if ((a%7 == 0)&(a%23==0)) Console.WriteLine($"Число {a} кратно числу 7 и 23");
else Console.WriteLine($"Число {a} не кратно 7 и не кратно 23");
if(a%7 == 0) Console.WriteLine($"{a} кратно 7");
else Console.WriteLine($"{a} не кратно 7");
if(a%23 == 0) Console.WriteLine($"{a} кратно 23");
else Console.WriteLine($"{a}  не кратно 23");





