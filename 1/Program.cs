/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/


Console.Write("Введите число ");
string stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);
Console.Write("Введите число ");
string stringValue1 = Console.ReadLine();
int value1 = Convert.ToInt32(stringValue1);
if (value > value1)
{
    Console.WriteLine($" {value} max");
}
Console.WriteLine($"{value1} max");

