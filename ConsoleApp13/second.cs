using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
    {
        double realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
        double imaginaryPart = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
    {
        double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
        if (denominator == 0)
            throw new DivideByZeroException("Cant divide");

        double realPart = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator;
        double imaginaryPart = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator;
        return new ComplexNumber(realPart, imaginaryPart);
    }

    public override string ToString()
    {
        if (Imaginary >= 0)
            return $"{Real} + {Imaginary}i";
        else
            return $"{Real} - {-Imaginary}i";
    }
}
