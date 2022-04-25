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


int N = 12551;
string result = method(N);
Console.WriteLine(result);