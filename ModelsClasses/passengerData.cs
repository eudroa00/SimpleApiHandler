using System;

public class PassengerAddress
{
    public string country { get; set; }
    public string city { get; set; }
    public string street { get; set; }
    public string pc { get; set; }
}

public class BookedServices
{
    public string baggage { get; set; }
    public bool catering { get; set; }
    public bool fastTrack { get; set; }
    public bool insurance { get; set; }
}

public class ContactData
{
    public PassengerAddress address { get; set; }
    public long phoneNumber { get; set; }
    public string email { get; set; }
}

public class FlightTicketData
{
    public string @class { get; set; }
    public string seat { get; set; }
    public int cost { get; set; }
    public int tiketId { get; set; }
}

public class IdentificationData
{
    public string name { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
    public DateTime birthdate { get; set; }
    public string nationality { get; set; }
    public bool visa { get; set; }
}

public class passengerData
{
    public IdentificationData identificationData { get; set; }
    public ContactData contactData { get; set; }
    public FlightTicketData flightTicketData { get; set; }
    public BookedServices bookedServices { get; set; }
    public string _id { get; set; }
    public string flightNumber { get; set; }
}


