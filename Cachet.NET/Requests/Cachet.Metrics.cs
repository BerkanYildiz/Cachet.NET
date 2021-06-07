namespace Cachet.NET
{
    using System;
    using System.Threading.Tasks;

    using global::Cachet.NET.Responses;
    using global::Cachet.NET.Responses.Objects;

    public partial class Cachet
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
        public async Task<MetricsResponse> GetMetricsAsync()
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

        /// <summary>
        /// Adds a new metric to the Cachet API.
        /// </summary>
        /// <param name="Name">The metric's name.</param>
        /// <param name="Description">The metric's description.</param>
        /// <param name="Suffix">The metric's points suffix.</param>
        /// <param name="DefaultValue">The default value for points.</param>
        /// <param name="DisplayChart">Whether to display the chart on the home page.</param>
        public MetricResponse AddMetric(string Name, string Description, string Suffix, int DefaultValue = 0, bool DisplayChart = false)
        {
            return this.Post<MetricResponse>("metrics", new
            {
                name = Name,
                suffix = Suffix,
                description = Description,
                default_value = DefaultValue,
                display_chart = DisplayChart ? 1 : 0,
            });
        }

        /// <summary>
        /// Adds a new metric to the Cachet API asynchronously.
        /// </summary>
        /// <param name="Name">The metric's name.</param>
        /// <param name="Description">The metric's description.</param>
        /// <param name="Suffix">The metric's points suffix.</param>
        /// <param name="DefaultValue">The default value for points.</param>
        /// <param name="DisplayChart">Whether to display the chart on the home page.</param>
        public async Task<MetricResponse> AddMetricAsync(string Name, string Description, string Suffix, int DefaultValue = 0, bool DisplayChart = false)
        {
            return await this.PostAsync<MetricResponse>("metrics", new
            {
                name = Name,
                suffix = Suffix,
                description = Description,
                default_value = DefaultValue,
                display_chart = DisplayChart ? 1 : 0,
            });
        }

        /// <summary>
        /// Deletes the specified metric from the Cachet API.
        /// </summary>
        /// <param name="Metric">The metric.</param>
        public bool DeleteMetric(MetricObject Metric)
        {
            return this.DeleteMetric(Metric.Id);
        }

        /// <summary>
        /// Deletes the specified metric from the Cachet API asynchronously.
        /// </summary>
        /// <param name="Metric">The metric.</param>
        public async Task<bool> DeleteMetricAsync(MetricObject Metric)
        {
            return await this.DeleteMetricAsync(Metric.Id);
        }

        /// <summary>
        /// Deletes the specified metric from the Cachet API.
        /// </summary>
        /// <param name="MetricId">The metric's id.</param>
        public bool DeleteMetric(int MetricId)
        {
            return this.Delete($"metrics/{MetricId}");
        }

        /// <summary>
        /// Deletes the specified metric from the Cachet API asynchronously.
        /// </summary>
        /// <param name="MetricId">The metric's id.</param>
        public async Task<bool> DeleteMetricAsync(int MetricId)
        {
            return await this.DeleteAsync($"metrics/{MetricId}");
        }

        /// <summary>
        /// Deletes the specified metric point from the Cachet API.
        /// </summary>
        /// <param name="MetricPoint">The metric point.</param>
        public bool DeleteMetricPoint(MetricPointObject MetricPoint)
        {
            return this.DeleteMetricPoint(MetricPoint.MetricId, MetricPoint.Id);
        }

        /// <summary>
        /// Deletes the specified metric point from the Cachet API asynchronously.
        /// </summary>
        /// <param name="MetricPoint">The metric point.</param>
        public async Task<bool> DeleteMetricPointAsync(MetricPointObject MetricPoint)
        {
            return await this.DeleteMetricPointAsync(MetricPoint.MetricId, MetricPoint.Id);
        }

        /// <summary>
        /// Deletes the specified metric point from the Cachet API.
        /// </summary>
        /// <param name="MetricId">The metric's id.</param>
        /// <param name="MetricPointId">The metric point's id.</param>
        public bool DeleteMetricPoint(int MetricId, int MetricPointId)
        {
            return this.Delete($"metrics/{MetricId}/points/{MetricPointId}");
        }

        /// <summary>
        /// Deletes the specified metric point from the Cachet API asynchronously.
        /// </summary>
        /// <param name="MetricId">The metric's id.</param>
        /// <param name="MetricPointId">The metric point's id.</param>
        public async Task<bool> DeleteMetricPointAsync(int MetricId, int MetricPointId)
        {
            return await this.DeleteAsync($"metrics/{MetricId}/points/{MetricPointId}");
        }
    }
}
