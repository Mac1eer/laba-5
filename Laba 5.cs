Console.WriteLine("Введите кол-во значейний в массиве");
int N = Convert.ToInt32(Console.ReadLine());
int[]mas = new int[N];
for (int i = 0; i < N; i++)
{
    Console.WriteLine("Введите число");
    mas[i] = Convert.ToInt32(Console.ReadLine());
}
int min = mas[0];
int max = mas[0];
for (int i = 0; i < N ; i++)
{
    if (mas[i] < min)
    {
        min = mas[i];
    }
}
for (int i = 0;i < N ; i++)
{
    if (mas[i] > max)
    {
        max = mas[i];
    }
}
int temp = min;
min = max;
max = temp;
for (int i = 0; i<N ; i++)
{
    mas[i] = i;
    Console.WriteLine(mas[i]);
}

