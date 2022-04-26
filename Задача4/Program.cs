string method(int N)
{
    int num1 = N / 10000;
    int num2 = N / 1000 % 10;
    int num4 = N / 10 % 10;
    int num5 = N % 10;

    if (num1 == num5 && num2 == num4)
    {
        return "Да";
    }
    else
    {
        return "Нет";
    }
}


int N = 1235;
if (N >= 10000 && N <= 99999)
{
    string result = method(N);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не пятизначное");
}