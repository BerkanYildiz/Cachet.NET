namespace Cachet.NET
{
    using System;
    using System.Threading.Tasks;

    using global::Cachet.NET.Responses;
    using global::Cachet.NET.Responses.Objects;

    public partial class Cachet : IDisposable
    {
        /// <summary>
        /// Gets the metrics from the Cachet API.
        /// </summary>
        public MetricsResponse GetMetrics()
        {
            return this.Get<MetricsResponse>("metrics");
        }

        /// <summary>
        /// Gets the metrics from the Cachet API.
        /// </summary>
        public async Task<MetricsResponse> GetMetricAsync()
        {
            return await this.GetAsync<MetricsResponse>("metrics");
        }

        /// <summary>
        /// Gets the specified metric from the Cachet API.
        /// </summary>
        /// <param name="MetricId">The metric identifier.</param>
        public MetricResponse GetMetric(int MetricId)
        {
            return this.Get<MetricResponse>($"metrics/{MetricId}");
        }

        /// <summary>
        /// Gets the specified metric from the Cachet API.
        /// </summary>
        /// <param name="MetricId">The metric identifier.</param>
        public async Task<MetricResponse> GetMetricAsync(int MetricId)
        {
            return await this.GetAsync<MetricResponse>($"metrics/{MetricId}");
        }

        /// <summary>
        /// Gets the specified metric's points from the Cachet API.
        /// </summary>
        /// <param name="MetricId">The metric identifier.</param>
        public MetricPointsResponse GetMetricPoints(int MetricId)
        {
            return this.Get<MetricPointsResponse>($"metrics/{MetricId}/points");
        }

        /// <summary>
        /// Gets the specified metric's points from the Cachet API.
        /// </summary>
        /// <param name="MetricId">The metric identifier.</param>
        public async Task<MetricPointsResponse> GetMetricPointsAsync(int MetricId)
        {
            return await this.GetAsync<MetricPointsResponse>($"metrics/{MetricId}/points");
        }

        /// <summary>
        /// Adds a point to the specified metric from the Cachet API.
        /// </summary>
        /// <param name="Metric">The metric.</param>
        /// <param name="PointValue">The value of the point being added.</param>
        /// <param name="Timestamp">The timestamp of the point being added.</param>
        public MetricPointResponse AddMetricPoint(MetricObject Metric, int PointValue, DateTime? Timestamp = null)
        {
            return this.AddMetricPoint(Metric.Id, PointValue, Timestamp);
        }

        /// <summary>
        /// Adds a point to the specified metric from the Cachet API.
        /// </summary>
        /// <param name="Metric">The metric.</param>
        /// <param name="PointValue">The value of the point being added.</param>
        /// <param name="Timestamp">The timestamp of the point being added.</param>
        public async Task<MetricPointResponse> AddMetricPointAsync(MetricObject Metric, int PointValue, DateTime? Timestamp = null)
        {
            return await this.AddMetricPointAsync(Metric.Id, PointValue, Timestamp);
        }

        /// <summary>
        /// Adds a point to the specified metric from the Cachet API.
        /// </summary>
        /// <param name="MetricId">The metric identifier.</param>
        /// <param name="PointValue">The value of the point being added.</param>
        /// <param name="Timestamp">The timestamp of the point being added.</param>
        public MetricPointResponse AddMetricPoint(int MetricId, int PointValue, DateTime? Timestamp = null)
        {
            if (Timestamp.HasValue)
            {
                return this.Post<MetricPointResponse>($"metrics/{MetricId}/points", new
                {
                    value = PointValue,
                    timestamp = Timestamp.Value
                });
            }
            else
            {
                return this.Post<MetricPointResponse>($"metrics/{MetricId}/points", new
                {
                    value = PointValue,
                });
            }
        }

        /// <summary>
        /// Adds a point to the specified metric from the Cachet API.
        /// </summary>
        /// <param name="MetricId">The metric identifier.</param>
        /// <param name="PointValue">The value of the point being added.</param>
        /// <param name="Timestamp">The timestamp of the point being added.</param>
        public async Task<MetricPointResponse> AddMetricPointAsync(int MetricId, int PointValue, DateTime? Timestamp = null)
        {
            if (Timestamp.HasValue)
            {
                return await this.PostAsync<MetricPointResponse>($"metrics/{MetricId}/points", new
                {
                    value = PointValue,
                    timestamp = Timestamp.Value
                });
            }
            else
            {
                return await this.PostAsync<MetricPointResponse>($"metrics/{MetricId}/points", new
                {
                    value = PointValue,
                });
            }
        }
    }
}
