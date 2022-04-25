double Method(double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    double lengX = (Bx - Ax);
    double lengY = (By - Ay);
    double lengZ = (Bz - Az);
    double result = Math.Sqrt(lengX * lengX + lengY * lengY + lengZ * lengZ);
    return result;
}

double Ax = 3;
double Ay = 6;
double Az = 8;
double Bx = 2;
double By = 1;
double Bz = -7;


double result = Method(Ax, Ay, Az, Bx, By, Bz);
Console.WriteLine(result);