double Method(double Ax, double Ay, double Bx, double By)
{
    double lengX = (Bx - Ax);
    double lengY = (By - Ay);
    double Axy = Math.Sqrt(lengX * lengX + lengY * lengY);
    return Axy;
}

double Ax = 3;
double Ay = 4;
double Bx = 7;
double By = 9;

Double result = Method(Ax, Ay, Bx, By);
Console.WriteLine(result);