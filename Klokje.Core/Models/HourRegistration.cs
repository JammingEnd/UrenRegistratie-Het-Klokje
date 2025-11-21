using System;
using System.Collections.Generic;
using System.Text;

namespace HetKlokje.Core.Models
{
    public class HourRegistration
    {
        public readonly uint Id;
        public Client RegisteredBy { get; set; }
        public Project Project { get; set; }
        public DateTime Date { get; set; }
        public double Hours { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public RegistryStatus Status { get; set; }

        // Constructor without id for creating new hour registrations
        public HourRegistration(Client registeredBy, Project project, DateTime date, double hours, string description, string comment, RegistryStatus status)
        {
            RegisteredBy = registeredBy;
            Project = project;
            Date = date;
            Hours = hours;
            Description = description;
            Comment = comment;
            Status = status;
        }
        // Constructor with id for existing hour registrations from the database
        public HourRegistration(uint id, Client registeredBy, Project project, DateTime date, double hours, string description, string comment, int status)
        {
            Id = id;
            RegisteredBy = registeredBy;
            Project = project;
            Date = date;
            Hours = hours;
            Description = description;
            Comment = comment;
            Status = (RegistryStatus)status;
        }
    }

    public enum RegistryStatus
    {
        Pending,
        Approved,
        Rejected,
    }
}
