# Cachet.NET
C# client library for the open-source Cachet status page system.

# Example

```csharp
using Cachet.NET;

var Cachet = new Cachet("https://demo.cachethq.io/api/v1/", "aegrHARGrgsfhryae"); // Token
var Cachet = new Cachet("https://demo.cachethq.io/api/v1/", "demo@cachethq.io", "password"); // Account

var ComponentsResult = Cachet.GetComponents();
var ComponentResult  = await Cachet.GetComponentsAsync();

foreach (var Component in ComponentsResult.Components)
{
    // Component.Id
    // Component.Name
    // Component.Status
    // Component.Tags
    // ...
}

bool isPingValid  = Cachet.Ping();
bool isPingValid  = async Cachet.PingAsync();

string CachetVer  = Cachet.GetVersion();
string CachetVer  = await Cachet.GetVersion();

if (CachetVersion.Meta.OnLatest)
{
    Console.WriteLine("Cachet is up to date!");
}
```

# Licence
This work is licensed under the MIT License.
