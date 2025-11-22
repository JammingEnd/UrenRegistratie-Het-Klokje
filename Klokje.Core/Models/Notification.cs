using System;
using System.Collections.Generic;
using System.Text;

namespace Klokje.Core.Models
{
    public class Notification
    {
        public readonly uint Id;
        public HourRegistration? HourSubject { get; set; } = null;
        public Project? ProjectSubject { get; set; } = null;
        public string Title { get; set; }
        public string Message { get; set; }
        public NotificationStatus Status { get; set; }
        // Constructor without id for creating new notifications
        public Notification(HourRegistration hourSubject, Project projectSubject, string message, string title, NotificationStatus status)
        {
            HourSubject = hourSubject;
            ProjectSubject = projectSubject;
            Message = message;
            Status = status;
            Title = title;
        }
        // Constructor with id for existing notifications from the database
        public Notification(uint id, HourRegistration hourSubject, Project projectSubject, string message, string title, int status)
        {
            Id = id;
            HourSubject = hourSubject;
            ProjectSubject = projectSubject;
            Message = message;
            Status = (NotificationStatus)status;
            Title = title;
        }
    }

    public enum  NotificationStatus
    {
        Read,
        Unread,
        Deleted,
    }
}
