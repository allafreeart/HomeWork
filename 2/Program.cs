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
Console.Write("Введите число ");
string stringValue2 = Console.ReadLine();
int value2 = Convert.ToInt32(stringValue2);

int max = value;
if (max < value1)
{
max = value1;
}
if (max < value2)
{
max = value2;
}
Console.WriteLine($"число {max} max");
