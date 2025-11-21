using System;
using System.Collections.Generic;
using System.Text;

namespace HetKlokje.Core.Models
{
    public class Notification
    {
        public readonly uint Id;
        public Client Recipient { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public NotificationStatus Status { get; set; }
        // Constructor without id for creating new notifications
        public Notification(Client recipient, string message, string title, NotificationStatus status)
        {
            Recipient = recipient;
            Message = message;
            Status = status;
            Title = title;
        }
        // Constructor with id for existing notifications from the database
        public Notification(uint id, Client recipient, string message, string title, int status)
        {
            Id = id;
            Recipient = recipient;
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
