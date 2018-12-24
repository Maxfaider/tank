using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext appContext = AppContext.GetIntance();

            appContext.SetAttribute("nameApp", "Tank!");
            appContext.SetAttribute("version", new Version("1.0.0"));

            appContext.AddEvent("onAlert", (eventArgs) =>
            {
                Console.WriteLine($@"Name: { appContext.GetAttribute("nameApp") }, Version: { appContext.GetAttribute("version") }");
            });

            appContext.EmitEvent("onAlert");
            Console.ReadKey();
        }
    }
}
