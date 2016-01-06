using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthNet.POCs.EventModel.Libraries.Core
{
    class WebhookNotificationSetting : NotificationEndpoint
    {
        public string Url { get; set; }
    }
}
