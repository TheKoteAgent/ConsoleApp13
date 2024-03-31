using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 3);
            Console.WriteLine($"f1 = {f1}, f2 = {f2}");
            Console.WriteLine($"f1 + f2 = {f1 + f2}");
            Console.WriteLine($"f1 - f2 = {f1 - f2}");
            Console.WriteLine($"f1 * f2 = {f1 * f2}");
            Console.WriteLine($"f1 / f2 = {f1 / f2}");

            //2
            ComplexNumber c1 = new ComplexNumber(1, 2);
            ComplexNumber c2 = new ComplexNumber(1, 3);
            Console.WriteLine($"c1 = {c1}, c2 = {c2}");
            Console.WriteLine($"c1 + c2 = {c1 + c2}");
            Console.WriteLine($"c1 - c2 = {c1 - c2}");
            Console.WriteLine($"c1 * c2 = {c1 * c2}");
            Console.WriteLine($"c1 / c2 = {c1 / c2}");

            //3
            Birthday birthday = new Birthday(1, 4, 1990);
            Console.WriteLine($"Day of the week: {birthday.GetDayOfTheWeek()}");
            Console.WriteLine($"Day of the week in 2025: {birthday.GetDayOfTheWeekInYear(2025)}");
            Console.WriteLine($"Days until birthday: {birthday.DaysUntilBirthday()}");
        }
    }
}
