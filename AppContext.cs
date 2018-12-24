using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    class AppContext
    {
        private static readonly AppContext appContext = new AppContext();

        public Dictionary<string, object> attributes;
       
        public static AppContext GetIntance()
        {
            return appContext;
        }

        public AppContext()
        {}

        public void SetAttribute(string name, object value) => attributes.Add(name, value);

        public object GetAttribute(string name) => attributes[name];

    }
}
