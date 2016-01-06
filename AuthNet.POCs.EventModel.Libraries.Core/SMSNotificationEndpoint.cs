using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthNet.POCs.EventModel.Libraries.Core
{
    class SmsNotificationSetting : NotificationEndpoint
    {
        public string PhoneNumber { get; set; }
    }
}
