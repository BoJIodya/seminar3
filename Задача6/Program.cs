void Tablice(int N)
{
    for (int i = 1; i <= N; i++)
    {
        int j = i * i * i;
        Console.Write($"{j} ");
    }

}

int N = 9;
Tablice(N);