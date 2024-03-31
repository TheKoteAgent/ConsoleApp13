using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Birthday
{
    public DateTime BirthDate { get; private set; }

    public Birthday(int day, int month, int year)
    {
        BirthDate = new DateTime(year, month, day);
    }

    public string GetDayOfTheWeek()
    {
        return BirthDate.DayOfWeek.ToString();
    }

    public string GetDayOfTheWeekInYear(int year)
    {
        DateTime targetDate = new DateTime(year, BirthDate.Month, BirthDate.Day);
        return targetDate.DayOfWeek.ToString();
    }

    public int DaysUntilBirthday()
    {
        DateTime today = DateTime.Today;
        DateTime nextBirthday = new DateTime(today.Year, BirthDate.Month, BirthDate.Day);
        if (nextBirthday < today)
            nextBirthday = nextBirthday.AddYears(1);

        return (nextBirthday - today).Days;
    }
}
