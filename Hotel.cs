using System;

class Hotel
{
    static void Main(string[] args)
    {
        var month = Console.ReadLine();
        var days = int.Parse(Console.ReadLine());
        double studioPrice = 0;
        double apartmentPrice = 0;


        switch (month)
        {
            case "May":
            case "October":
                studioPrice = 50.00;
                apartmentPrice = 65.00;
                if (days > 14)
                {
                    apartmentPrice *= 0.90;
                    studioPrice *= 0.70;
                }
                else if (days > 7)
                {
                    studioPrice *= 0.95;
                }
                break;

            case "June":
            case "September":
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (days > 14)
                {
                    studioPrice *= 0.80;
                    apartmentPrice *= 0.90;
                }
                break;

            case "July":
            case "August":
                studioPrice = 76.00;
                apartmentPrice = 77.00;
                if (days > 14)
                {
                    apartmentPrice *= 0.90;
                }
                break;
        }
        Console.WriteLine($"Apartment: {days * apartmentPrice:F2} lv.");
        Console.WriteLine($"Studio: {days * studioPrice:F2} lv.");
    }
}
