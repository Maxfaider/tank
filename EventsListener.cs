using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{

    public delegate void GenericEventHandler(GenericEventArgs eventArgs);

    public class EventsListener
    {
        Dictionary<string, GenericEventHandler> events;
        string nameListener;
        string dateCreated;

        public static EventsListener newEventsListener(string name) => new EventsListener(name);

        private EventsListener(string name)
        {
            this.nameListener = name;
            this.dateCreated = DateTime.Now.ToString("f");
        }

        public void RegisterEvents(string name, GenericEventHandler callback)
        {
            events.Add(name, callback);
        }

        public GenericEventHandler GetEvent(string name)
        {
            return events[name];
        }

        public string NameListener
        {
            get { return nameListener; }
        }

        public string DateCreated
        {
            get { return dateCreated; }
        }

    }
}
