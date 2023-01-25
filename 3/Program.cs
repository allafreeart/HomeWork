/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */


Console.Write("Введите число ");
string value = Console.ReadLine();
int a = Convert.ToInt32(value);
if (a % 2 == 0)
{
    Console.WriteLine($" {a} четное");
}
else Console.WriteLine($"{a} нечетное");
