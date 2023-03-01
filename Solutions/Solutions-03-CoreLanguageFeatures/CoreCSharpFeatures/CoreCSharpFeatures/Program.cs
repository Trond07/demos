using System;

string cityName = "Swansea";
long population = 225000;
double longitude = 4.5;
double latitude = 51.9;

double annualRainfall = 12345;   // Slight exageration...
double annualSunHours = 1000;    // :-)

Console.WriteLine("General info for {0}", cityName);
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Population {0}\n" +
                  "Longitude {1}\n" +
                  "Latitute {2}\n" +
                  "Annual rainfall {3}\n" +
                  "Sunshine hours {4}",
                  population, longitude, latitude, annualRainfall, annualSunHours);

double males = population / 2;
double minutesLaterThanLondon = 60 * (longitude / 15); // 15 degrees = 1 hour on the international clock.
double degreesFromPole = 90 - latitude;

long currentPopulation = population++;
long populationAfter1Birth = population;
long populationAfter2Births = ++population;

double monthlyRainfall = annualRainfall / 12;
double dailySunHours = annualSunHours / 365;

Console.WriteLine("\nDetails for {0}", cityName);
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Statistical male count {0}\n" +
                  "Minutes later than London {1}\n" +
                  "Degrees from Pole {2}\n" +
                  "Current population {3}\n" +
                  "Population after 1 birth {4}\n" +
                  "Population after 2 births {5}\n" +
                  "Average monthly rainfall {6}\n" +
                  "Average daily hours of sunshine {7}",
                  males, minutesLaterThanLondon, degreesFromPole, currentPopulation, populationAfter1Birth, populationAfter2Births, monthlyRainfall, dailySunHours);

// Optional part.
const double PI = 3.1415;

Console.Write("Please enter the radius of a circle: ");
double radius = Convert.ToDouble(Console.ReadLine());

double area = PI * radius * radius;
double circumference = 2 * PI * radius;

Console.WriteLine("Area of circle: {0}", area);
Console.WriteLine("Circumference:  {0}", circumference);
