// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int[] array = {20, 40, 21};
int index = 0;
int max = 0;
while (index < array.Length -1)
{
  if (array[index] > max)
  {
    max = array[index]; 
  }
index = index + 1;
}

Console.WriteLine("максимум " + max);
