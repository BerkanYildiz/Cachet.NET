namespace Cachet.NET
{
    using System;
    using System.Threading.Tasks;

    using global::Cachet.NET.Responses;

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
    }
}
