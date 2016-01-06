using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthNet.POCs.EventModel.Libraries.Core
{
    class Subscription
    {
        public int Id { get; set; }
        public int MerchantId { get; set; }
        public EventType EventType { get; set; }
        public NotificationEndpoint NotificationEndpoint { get; set; }
    }
}
