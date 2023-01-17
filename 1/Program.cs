/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/


Console.Write("Введите число ");
string number = Console.ReadLine();
int a = Convert.ToInt32 (number);
Console.Write("Введите число ");
string number1 = Console.ReadLine();
int b = Convert.ToInt32 (number);
if (a>b)
{
System.Console.WriteLine($"число {a} большее");  
}
else System.Console.WriteLine($"число {b} большее");  