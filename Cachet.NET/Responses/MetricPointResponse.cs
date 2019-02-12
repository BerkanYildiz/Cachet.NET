namespace Cachet.NET.Responses
{
    using global::Cachet.NET.Responses.Objects;

    using RestSharp.Deserializers;

    public class MetricPointResponse
    {
        /// <summary>
        /// Gets or sets the metric's point.
        /// </summary>
        [DeserializeAs(Name = "data")]
        public MetricPointObject Point
        {
            get;
            set;
        }
    }
}
