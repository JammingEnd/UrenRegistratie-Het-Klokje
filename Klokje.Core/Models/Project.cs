using System;
using System.Collections.Generic;
using System.Text;

namespace HetKlokje.Core.Models
{
    public class Project
    {
        public readonly uint Id;
        public string ProjectName { get; set; }

        public Client ProjectLead { get; set; }

        public List<Client> TeamMembers { get; set; }

        public ProjectStatus Status { get; set; }

        public string BusinessName { get; set; }
        public int AssignedHours { get; set; }
        public int ThresholdHours { get; set; }
        public double Tariff { get; set; }

        public RegistryType RegistryType { get; set; }

        // Constructor without id for creating new projects
        public Project(string projectName, Client projectLead, List<Client> teamMembers, ProjectStatus status, string businessName, int assignedHours, int thresholdHours, double tariff, RegistryType registryType)
        {
            ProjectName = projectName;
            ProjectLead = projectLead;
            TeamMembers = teamMembers;
            Status = status; // Cast int to ProjectStatus enum cause the int is saved in the database
            BusinessName = businessName;
            AssignedHours = assignedHours;
            ThresholdHours = thresholdHours;
            Tariff = tariff;
            RegistryType = registryType; // Cast int to RegistryType enum cause the int is saved in the database
        }

        // Constructor with id for existing projects from the database
        public Project(uint id, string projectName, Client projectLead, List<Client> teamMembers, int status, string businessName, int assignedHours, int thresholdHours, double tariff, int registryType)
        {
            Id = id;
            ProjectName = projectName;
            ProjectLead = projectLead;
            TeamMembers = teamMembers;
            Status = (ProjectStatus)status; // Cast int to ProjectStatus enum cause the int is saved in the database
            BusinessName = businessName;
            AssignedHours = assignedHours;
            ThresholdHours = thresholdHours;
            Tariff = tariff;
            RegistryType = (RegistryType)registryType; // Cast int to RegistryType enum cause the int is saved in the database
        }
    }

    public enum ProjectStatus
    {
        Active,
        Inactive,
    }

    public enum RegistryType
    {
        InvoiceAble,
        NonInvoiceAble,
        PaidLeave,
    }
}