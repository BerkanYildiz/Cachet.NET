# Cachet.NET
.NET library to communicate with the CachetHQ API to create, manage, and handle outages.

## Installation

    PM> Install-Package Cachet.NET

## Example

```csharp
using Cachet.NET;

var Cachet = new Cachet("https://demo.cachethq.io/api/v1/"); // Demo
var Cachet = new Cachet("https://demo.cachethq.io/api/v1/", "aegrHARGrgsfhryae"); // Token
var Cachet = new Cachet("https://demo.cachethq.io/api/v1/", "demo@cachethq.io", "password"); // Account

var Version             = await Cachet.GetVersionAsync();
var Components          = await Cachet.GetComponentsAsync();
var ComponentGroups     = await Cachet.GetComponentGroupsAsync();
var Incidents           = await Cachet.GetIncidentsAsync();
var Metrics             = await Cachet.GetMetricsAsync();
var FirstMetric         = await Cachet.GetMetricAsync(1);
var FirstMetricPoints   = await Cachet.GetMetricPointsAsync(1);
var AddedMetric         = await Cachet.AddMetricAsync("Name", "Description", "Suffix", 0, DisplayChart: true);
var AddedMetricPoint    = await Cachet.AddMetricPointAsync(AddedMetric.Metric, new Random().Next(5000));
```

# Licence
This work is licensed under the MIT License.
