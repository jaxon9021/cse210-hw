using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address address2 = new Address("456 Park Ave", "New York", "NY", "USA");
        Address address3 = new Address("789 Beach Rd", "Miami", "FL", "USA");

        Event lecture = new Lecture(
            "Tech Conference",
            "Learn about the latest in technology",
            "May 10",
            "10:00 AM",
            address1,
            "Dr. Smith",
            100
        );

        Event reception = new Reception(
            "Networking Event",
            "Meet professionals in your field",
            "June 5",
            "6:00 PM",
            address2,
            "rsvp@company.com"
        );

        Event outdoor = new Outdoor(
            "Summer Festival",
            "Food, music, and fun",
            "July 20",
            "2:00 PM",
            address3,
            "Sunny with light breeze"
        );

        Event[] events = { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("STANDARD DETAILS:");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("FULL DETAILS:");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("SHORT DESCRIPTION:");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("=================================\n");
        }
    }
}