using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthNet.POCs.EventModel.Libraries.Core
{
    class EventTypeDefinitions
    {
        public static EventType ET1 = new EventType() { Id = 1, Name = "customer.payment.created", Description = "Event created when payment is created for the merchant" };

        public static EventType ET2 = new EventType() { Id = 2, Name = "customer.created", Description = "Event created when a Merchant creates a new customer profile" };

        public static EventType ET3 = new EventType() { Id = 3, Name = "customer.subscription.created", Description = "Event created when a subsricption is created for a customer" };

    }
}
