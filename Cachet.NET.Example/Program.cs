namespace Cachet.NET.Example
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    internal static class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        private static async Task Main()
        {
            using (var Cachet = new Cachet("https://demo.cachethq.io/api/v1/", ""))
            {
                Cachet.OnDisposed += (Sender, Args) =>
                {
                    Console.WriteLine("[*] The Cachet API client has been disposed.");
                };

                var IsPingValid = await Cachet.PingAsync();

                if (IsPingValid)
                {
                    var Version         = await Cachet.GetVersionAsync();
                    var Components      = await Cachet.GetComponentsAsync();
                    var ComponentGroups = await Cachet.GetComponentGroupsAsync();
                    var Incidents       = await Cachet.GetIncidentsAsync();

                    if (Version != null)
                    {
                        Console.WriteLine("[*] Version : " + Version.Meta.Latest.TagName + " [IsLatest : " + (Version.Meta.OnLatest ? "Yes" : "No") + "]");
                    }
                    else
                    {
                        Console.WriteLine("[*] Version : " + "(NULL)");
                    }

                    Console.WriteLine();

                    if (Components != null)
                    {
                        Console.WriteLine("[*] Components : ");

                        foreach (var Component in Components.Components)
                        {
                            Console.WriteLine("[*]  - " + Component.Name);

                            if (Component.Tags.Count == 1)
                            {
                                Console.WriteLine("[*]  -- Tags : " + Component.Tags.First());
                            }
                            else
                            {
                                Console.WriteLine("[*]  -- Tags : ");

                                foreach (var Tag in Component.Tags)
                                {
                                    Console.WriteLine("[*]  --- " + Tag + ".");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("[*] Components : (NULL)");
                    }

                    Console.WriteLine();

                    if (ComponentGroups != null)
                    {
                        Console.WriteLine("[*] Groups : ");

                        foreach (var Group in ComponentGroups.Groups)
                        {
                            Console.WriteLine("[*]  - " + Group.Name);
                        }
                    }
                    else
                    {
                        Console.WriteLine("[*] Groups : (NULL)");
                    }

                    Console.WriteLine();

                    if (Incidents != null)
                    {
                        Console.WriteLine("[*] Incidents : ");

                        foreach (var Incident in Incidents.Incidents)
                        {
                            Console.WriteLine("[*]  - " + Incident.Name);
                        }
                    }
                    else
                    {
                        Console.WriteLine("[*] Incidents : (NULL)");
                    }

                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("[*] Failed to ping the Cachet API !");
                }
            }

            Console.ReadKey(false);
        }
    }
}
