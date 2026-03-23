using System;

class Parallelogram
{
    private double a;
    private double b;
    private double angle;

    public Parallelogram()
    {
        a = 0;
        b = 0;
        angle = 0;
    }

    public Parallelogram(double a, double b, double angle)
    {
        this.a = a;
        this.b = b;
        this.angle = angle;
    }

    public void SetA(double value)
    {
        if (value >= 0)
            a = value;
    }

    public void SetB(double value)
    {
        if (value >= 0)
            b = value;
    }

    public void SetAngle(double value)
    {
        if (value >= 0 && value < 180)
            angle = value;
    }

    public double GetA()
    {
        return a;
    }

    public double GetB()
    {
        return b;
    }

    public double GetAngle()
    {
        return angle;
    }

    public double Perimeter()
    {
        return 2 * (a + b);
    }

    public double Area()
    {
        double rad = angle * Math.PI / 180;
        return a * b * Math.Sin(rad);
    }

    public void Diagonals(out double d1, out double d2)
    {
        double rad = angle * Math.PI / 180;
        double cos = Math.Cos(rad);
        
        d1 = Math.Sqrt(a * a + b * b - 2 * a * b * cos);
        d2 = Math.Sqrt(a * a + b * b + 2 * a * b * cos);
    }

    public void Heights(out double h1, out double h2)
    {
        double rad = angle * Math.PI / 180;
        double s = Math.Sin(rad);
        
        h1 = b * s;
        h2 = a * s;
    }

    public void PrintInfo(string name)
    {
        Diagonals(out double d1, out double d2);
        Heights(out double h1, out double h2);

        Console.WriteLine($"\nПАРАЛЕЛОГРАМ {name}");
        Console.WriteLine($"a = {GetA()}; b = {GetB()}; кут = {GetAngle()}");
        Console.WriteLine($"Периметр: {Perimeter()}");
        Console.WriteLine($"Площа: {Area():F2}");
        Console.WriteLine($"Діагоналі: {d1:F2}; {d2:F2}");
        Console.WriteLine($"Висоти: {h1:F2}; {h2:F2}");
    }
}
