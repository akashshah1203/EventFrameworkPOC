using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthNet.POCs.EventModel.Libraries.Core
{
    class SubscriptionManager
    {
        public Subscription Subscribe(Subscription subscription)
        {
            return subscription;
        }

        public Subscription Subscribe(int merchantId,EventType eventType,int notificationType) 
        {
            Subscription subscription = new Subscription();

            return subscription;
        }

        public List<Subscription> GetSubscriptions(int merchantId) 
        {  
            List<Subscription> subscriptions = new List<Subscription>();

            return subscriptions;
        }

        public Subscription GetSubscription(int subscriptionId)
        {
            Subscription subscription = new Subscription();

            return subscription;
        }

        public Subscription Unsubscribe(int merchantId) 
        {
            Subscription subscription = new Subscription();

            return subscription;
        }

        public Subscription Unsubscribe(Subscription subscriptionObj)
        {
            Subscription subscription = new Subscription();

            return subscription;
        }


    }
}
