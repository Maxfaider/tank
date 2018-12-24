using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    public class AppContext
    {
        private static readonly AppContext appContext = new AppContext();

        public Dictionary<string, object> attributes;
        public EventsListener eventsListener;

        public static AppContext GetIntance() => appContext;

        public AppContext()
        {
            eventsListener = EventsListener.newEventsListener("Global");
            attributes = new Dictionary<string, object>();
        }

        public void SetAttribute(string name, object value) => attributes.Add(name, value);

        public object GetAttribute(string name) => attributes[name];

        public void AddEvent(string name, GenericEventHandler callback) => eventsListener.RegisterEvents(name, callback);

        public void EmitEvent(string name)
        {
            GenericEventHandler callback = eventsListener.GetEvent(name);
            if( callback != null)
                Task.Run(() => callback(new GenericEventArgs()));
        }

    }
}
