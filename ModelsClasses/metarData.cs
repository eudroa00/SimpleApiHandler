using System.Collections.Generic;
using System;

public class Barometer
{
    public double hg { get; set; }
    public int hpa { get; set; }
    public double kpa { get; set; }
    public double mb { get; set; }
}

public class Cloud
{
    public string code { get; set; }
    public string text { get; set; }
}

public class Datum
{
    public Barometer barometer { get; set; }
    public List<Cloud> clouds { get; set; }
    public Dewpoint dewpoint { get; set; }
    public Elevation elevation { get; set; }
    public string flight_category { get; set; }
    public Humidity humidity { get; set; }
    public string icao { get; set; }
    public string observed { get; set; }
    public string raw_text { get; set; }
    public Station station { get; set; }
    public Temperature temperature { get; set; }
    public Visibility visibility { get; set; }
    public Wind wind { get; set; }
}

public class Dewpoint
{
    public int celsius { get; set; }
    public int fahrenheit { get; set; }
}

public class Elevation
{
    public int feet { get; set; }
    public int meters { get; set; }
}

public class Geometry
{
    public List<double> coordinates { get; set; }
    public string type { get; set; }
}

public class Humidity
{
    public int percent { get; set; }
}

public class metarData
{
    public List<Datum> data { get; set; }
    public string _id { get; set; }
    public int results { get; set; }
}

public class Station
{
    public Geometry geometry { get; set; }
    public string icao { get; set; }
    public string location { get; set; }
    public string name { get; set; }
    public string type { get; set; }
}

public class Temperature
{
    public int celsius { get; set; }
    public int fahrenheit { get; set; }
}

public class Visibility
{
    public string meters { get; set; }
    public int meters_float { get; set; }
    public string miles { get; set; }
    public int miles_float { get; set; }
}

public class Wind
{
    public int degrees { get; set; }
    public int speed_kph { get; set; }
    public int speed_kts { get; set; }
    public int speed_mph { get; set; }
    public int speed_mps { get; set; }
}

