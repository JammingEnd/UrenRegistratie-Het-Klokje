using System;
using System.Collections.Generic;
using System.Text;

namespace Klokje.Core.Models
{
    public class Invoice
    {
        public readonly uint Id;
        public Project Project { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalHours { get; set; }
        public int Tariff { get; set; }

        // Constructor without id for creating new invoices
        public Invoice(Project project, DateTime startDate, DateTime endDate, int totalHours, int tariff)
        {
            Project = project;
            StartDate = startDate;
            EndDate = endDate;
            TotalHours = totalHours;
            Tariff = tariff;
        }
        // Constructor with id for existing invoices from the database
        public Invoice(uint id, Project project, DateTime startDate, DateTime endDate, int totalHours, int tariff)
        {
            Id = id;
            Project = project;
            StartDate = startDate;
            EndDate = endDate;
            TotalHours = totalHours;
            Tariff = tariff;
        }

    }
}
