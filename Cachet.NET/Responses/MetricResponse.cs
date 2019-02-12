namespace Cachet.NET.Responses
{
    using global::Cachet.NET.Responses.Objects;

    using RestSharp.Deserializers;

    public class MetricResponse
    {
        /// <summary>
        /// Gets or sets the metrics.
        /// </summary>
        [DeserializeAs(Name = "data")]
        public MetricObject Metric
        {
            get;
            set;
        }
    }
}
