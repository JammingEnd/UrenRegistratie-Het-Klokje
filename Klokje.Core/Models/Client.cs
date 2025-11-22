using System;
using System.Collections.Generic;
using System.Text;

namespace Klokje.Core.Models
{
    public class Client
    {
        public readonly uint Id;

        public string FirstName { get; set; }
        public string Infix { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ClientRole Role { get; set; }

        public int MinimumWorkHours { get; set; }
        public int InvoiceHoursPercentage { get; set; }

        // Constructor without id for creating new clients
        public Client(string firstname, string infix, string lastname, DateTime birth, string email, string password, ClientRole role, int minHours, int HourPerc)
        {
            FirstName = firstname;
            Infix = infix;
            LastName = lastname;
            BirthDate = birth;
            Email = email;
            Password = password;
            Role = role; // Cast int to ClientRole enum cause the int is saved in the database
            MinimumWorkHours = minHours;
            InvoiceHoursPercentage = HourPerc;
        }

        // Constructor with id for existing clients from the database
        public Client(uint id, string firstname, string infix, string lastname, DateTime birth, string email, string password, int role, int minHours, int HourPerc) 
        { 
            Id = id;
            FirstName = firstname;
            Infix = infix;
            LastName = lastname;
            BirthDate = birth;
            Email = email;
            Password = password;
            Role = (ClientRole)role; // Cast int to ClientRole enum cause the int is saved in the database
            MinimumWorkHours = minHours;
            InvoiceHoursPercentage = HourPerc;
        }

    }

    public enum ClientRole
    {
        Employee,
        ProjectLead,
        Admin
    }
}
