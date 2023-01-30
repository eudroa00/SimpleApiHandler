using System;

public class flightData
{
    public Aircraft aircraft { get; set; }
    public Departure departure { get; set; }
    public Arrival arrival { get; set; }
    public string _id { get; set; }
    public string flightNumber { get; set; }
    public string airlineName { get; set; }
    public int seatsAvailable { get; set; }
    public int seatsBooked { get; set; }
    public int flightDuration { get; set; }
    public string terminalId { get; set; }
    public string boardingGate { get; set; }
    public string status { get; set; }
}

public class Aircraft
{
    public string bodyType { get; set; }
    public string manufacturer { get; set; }
    public string type { get; set; }
    public int yearOfManufacture { get; set; }
    public string iataCode { get; set; }
    public string icaoCode { get; set; }
    public string registration { get; set; }
}

public class Arrival
{
    public string country { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string airportName { get; set; }
    public string iataCode { get; set; }
    public string icaoCode { get; set; }
    public DateTime time { get; set; }
}

public class Departure
{
    public string country { get; set; }
    public string state { get; set; }
    public string city { get; set; }
    public string airportName { get; set; }
    public string iataCode { get; set; }
    public string icaoCode { get; set; }
    public DateTime time { get; set; }
}

