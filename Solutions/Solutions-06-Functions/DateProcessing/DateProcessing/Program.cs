using DateProcessing;

Car.year = 2022;
Car.IncreaseYear();

Console.WriteLine(Car.year);

double v = Math.Sin(45);

//Class1 m_Class1 = new Class1();  // create an instance of MyClass
//m_Class1.test1 = 3;
//int value = m_Class1.test1;
//int value2 = Class1.
//Console.WriteLine(value);

//int year = PromptUserForNumber("Please enter a year between 0 and 2099 inclusive: ", 0, 2099);
//int month = PromptUserForNumber("Please enter a month between 1 and 12 inclusive: ", 1, 12);

//bool isLeapYearFlag = CalcIsLeapYear(year);
//int daysInMonth = CalcDaysInMonth(month, isLeapYearFlag);
//string monthName = CalcMonthName(month);

//int day = PromptUserForNumber($"Please enter a day between 1 and {daysInMonth} inclusive: ", 1, daysInMonth);
//Console.WriteLine($"\nThe specified date is {day}/{month}/{year}");

//Console.WriteLine($"\nHere are all the dates (in full format) in {month}/{year}");
//for (int d = 1; d <= daysInMonth; d++)
//{
//    string suffix = CalcSuffix(d);
//    Console.WriteLine("  {0}{1} {2} {3}", d, suffix, monthName, year);
//}



int PromptUserForNumber(string message, int min, int max)
{
    int num;
    do
    {
        Console.Write(message);
        num = Convert.ToInt32(Console.ReadLine());
    }
    while (num < min || num > max);
    return num;
}

bool CalcIsLeapYear(int year)
{
    return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
}

int CalcDaysInMonth(int month, bool isLeapYearFlag)
{
    int daysInMonth;

    switch (month)
    {
        case 2:
            if (isLeapYearFlag)
                daysInMonth = 29;
            else
                daysInMonth = 28;
            break;

        case 4:
        case 6:
        case 9:
        case 11:
            daysInMonth = 30;
            break;

        default:
            daysInMonth = 31;
            break;
    }
    return daysInMonth;
}

string CalcMonthName(int month)
{
    string monthName;
    switch (month)
    {
        case 1: monthName = "January"; break;
        case 2: monthName = "February"; break;
        case 3: monthName = "March"; break;
        case 4: monthName = "April"; break;
        case 5: monthName = "May"; break;
        case 6: monthName = "June"; break;
        case 7: monthName = "July"; break;
        case 8: monthName = "August"; break;
        case 9: monthName = "September"; break;
        case 10: monthName = "October"; break;
        case 11: monthName = "November"; break;
        case 12: monthName = "December"; break;
        default: monthName = "Not Known"; break;    // Should never happen
    }
    return monthName;
}

string CalcSuffix(int day)
{
    string suffix;
    switch (day)
    {
        case 1:
        case 21:
        case 31:
            suffix = "st";
            break;

        case 2:
        case 22:
            suffix = "nd";
            break;

        case 3:
        case 23:
            suffix = "rd";
            break;

        default:
            suffix = "th";
            break;
    }
    return suffix;
}