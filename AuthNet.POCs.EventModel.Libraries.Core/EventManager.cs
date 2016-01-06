using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthNet.POCs.EventModel.Libraries.Core
{
    class EventManager
    {
        public List<EventType> GetAllEvents()
        {
            List<EventType> eventTypeList = new List<EventType>();

            return eventTypeList;
        }

        public EventType Raise(EventType eventType)
        {
            return eventType;
        }
    }
}
