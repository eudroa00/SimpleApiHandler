using System;
using System.Collections.Generic;

public class Address
{
    public string city { get; set; }
    public string street { get; set; }
    public string pc { get; set; }
}

public class Contact
{
    public Phones phones { get; set; }
    public Address address { get; set; }
    public string personalEmail { get; set; }
    public string linkedin { get; set; }
}

public class EmergencyContact
{
    public string relationship { get; set; }
    public string name { get; set; }
    public long phone { get; set; }
    public string email { get; set; }
}

public class Phones
{
    public string personal { get; set; }
    public string home { get; set; }
}

public class employeeData
{
    public Contact contact { get; set; }
    public EmergencyContact emergencyContact { get; set; }
    public List<object> licenses { get; set; }
    public List<string> titles { get; set; }
    public string _id { get; set; }
    public string name { get; set; }
    public int age { get; set; }
    public string gender { get; set; }
    public DateTime birthday { get; set; }
    public string nationality { get; set; }
    public string cityOfBirth { get; set; }
    public string personalId { get; set; }
    public string passport { get; set; }
    public int socialSecurityNumber { get; set; }
    public DateTime hiringDate { get; set; }
    public DateTime finishingDateOfContract { get; set; }
    public List<string> licences { get; set; }
    public bool drivingLicence { get; set; }
    public string department { get; set; }
    public string company { get; set; }
    public string position { get; set; }
    public string corporateEmail { get; set; }
    public int salary { get; set; }
    public string password { get; set; }
    public string contractType { get; set; }
    public string maritalStatus { get; set; }
    public string employmentStatus { get; set; }
}