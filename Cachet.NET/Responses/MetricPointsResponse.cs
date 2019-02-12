namespace Cachet.NET.Responses
{
    using System.Collections.Generic;

    using global::Cachet.NET.Responses.Metas;
    using global::Cachet.NET.Responses.Objects;

    using RestSharp.Deserializers;

    public class MetricPointsResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="Meta"/>.
        /// </summary>
        public Meta Meta
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the metric's points.
        /// </summary>
        [DeserializeAs(Name = "data")]
        public List<MetricPointObject> Points
        {
            get;
            set;
        }
    }
}
