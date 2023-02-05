//Задача 23 Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27. 5 -> 1, 8, 27, 64, 125

Console.Clear();

int count = 0;
Console.Write("введте число N: ");
int N = Convert.ToInt32(Console.ReadLine());

while (count <= N)
{
    int kub = Convert.ToInt32(Math.Pow(count + 1, 3));
    if (count != N)
    {
        Console.WriteLine (kub);
    }
    count++;
}