// Задача: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a = -1;
int b = 1;
int max = a;
int min = b;
if(a > b)
{
    max = a;
    min = b;
}
else
{
  max = b;
  min = a;
}

Console.WriteLine("наименьшее " + min);
Console.WriteLine("наибольшее " + max);