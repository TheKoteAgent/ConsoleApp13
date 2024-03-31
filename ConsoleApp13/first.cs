using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("cant be zero");

        Numerator = numerator;
        Denominator = denominator;
        Simplify();
    }

    public void Simplify()
    {
        int gcd = GCD(Numerator, Denominator);
        Numerator /= gcd;
        Denominator /= gcd;

        if (Denominator < 0)
        {
            Numerator *= -1;
            Denominator *= -1;
        }
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        int numerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;
        int denominator = f1.Denominator * f2.Denominator;
        return new Fraction(numerator, denominator);
    }

    public static Fraction operator -(Fraction f1, Fraction f2)
    {
        int numerator = f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator;
        int denominator = f1.Denominator * f2.Denominator;
        return new Fraction(numerator, denominator);
    }

    public static Fraction operator *(Fraction f1, Fraction f2)
    {
        int numerator = f1.Numerator * f2.Numerator;
        int denominator = f1.Denominator * f2.Denominator;
        return new Fraction(numerator, denominator);
    }

    public static Fraction operator /(Fraction f1, Fraction f2)
    {
        if (f2.Numerator == 0)
            throw new DivideByZeroException("Cant divide");

        int numerator = f1.Numerator * f2.Denominator;
        int denominator = f1.Denominator * f2.Numerator;
        return new Fraction(numerator, denominator);
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
