namespace Cachet.NET.Example
{
    using System;
    using System.Linq;

    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        internal static void Main()
        {
            var Cachet = new Cachet("https://demo.cachethq.io/api/v1/", "");

            Console.WriteLine("Ping : " + Cachet.Ping() + ".");

            var Version = Cachet.GetVersion();

            Console.WriteLine("Version : " + Version.Meta.Latest.TagName);

            var Compo = Cachet.GetComponents();

            Console.WriteLine("Components : ");

            foreach (var Component in Compo.Components)
            {
                Console.WriteLine(" - " + Component.Name);

                if (Component.Tags.Count == 1)
                {
                    Console.WriteLine(" -- Tags : " + Component.Tags.First());
                }
                else
                {
                    Console.WriteLine(" -- Tags : ");

                    foreach (var Tag in Component.Tags)
                    {
                        Console.WriteLine(" --- " + Tag + ".");
                    }
                }

                Console.WriteLine();
            }

            var CompoGr = Cachet.GetComponentGroups();

            Console.WriteLine("Groups : ");

            foreach (var Group in CompoGr.Groups)
            {
                Console.WriteLine(" - " + Group.Name);
            }
            Console.WriteLine();

            var incidents = Cachet.GetIncidents();

            Console.WriteLine("Incidents : ");

            foreach (var incident in incidents.Incidents)
            {
                Console.WriteLine(" - " + incident.Name);
            }

            Console.ReadKey(false);
        }
    }
}
