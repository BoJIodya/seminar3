int F(int num1, int num2)
{
    if (num1 > 0 && num2 > 0)
    {
        return 1;
    }
    if (num1 < 0 && num2 > 0)
    {
        return 2;
    }
    if (num1 < 0 && num2 < 0)
    {
        return 3;
    }
    else
    {
        return 4;
    }
}


int x = 3;
int y = -5;
Console.WriteLine(F(x,y));