using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthNet.POCs.EventModel.Libraries.Core
{
    class NotificationEndpoint
    {
        public NotificationTypes notificationType { get; set; }

        public enum NotificationTypes
        {
            Email = 1,
            SMS = 2,
            Webhook = 3,
            Unknown = 10
        };
    }
}
