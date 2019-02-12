namespace Cachet.NET
{
    using System;
    using System.Threading.Tasks;

    using global::Cachet.NET.Responses;

    public partial class Cachet : IDisposable
    {
        /// <summary>
        /// Pings the Cachet API.
        /// </summary>
        public bool Ping()
        {
            var Response = this.Get<PingResponse>("ping");

            if (Response != null)
            {
                return Response.IsValid;
            }

            return false;
        }

        /// <summary>
        /// Pings the Cachet API.
        /// </summary>
        public async Task<bool> PingAsync()
        {
            var Response = await this.GetAsync<PingResponse>("ping");

            if (Response != null)
            {
                return Response.IsValid;
            }

            return false;
        }

        /// <summary>
        /// Gets the version of the Cachet API.
        /// </summary>
        public VersionResponse GetVersion()
        {
            return this.Get<VersionResponse>("version");
        }

        /// <summary>
        /// Gets the version of the Cachet API.
        /// </summary>
        public async Task<VersionResponse> GetVersionAsync()
        {
            return await this.GetAsync<VersionResponse>("version");
        }

        /// <summary>
        /// Gets the components of the Cachet API.
        /// </summary>
        public ComponentsResponse GetComponents()
        {
            return this.Get<ComponentsResponse>("components");
        }

        /// <summary>
        /// Gets the components of the Cachet API.
        /// </summary>
        public async Task<ComponentsResponse> GetComponentsAsync()
        {
            return await this.GetAsync<ComponentsResponse>("components");
        }

        /// <summary>
        /// Gets the specified component of the Cachet API.
        /// </summary>
        /// <param name="ComponentId">The component identifier.</param>
        public ComponentResponse GetComponent(int ComponentId)
        {
            return this.Get<ComponentResponse>($"components/{ComponentId}");
        }

        /// <summary>
        /// Gets the specified component of the Cachet API.
        /// </summary>
        /// <param name="ComponentId">The component identifier.</param>s
        public async Task<ComponentResponse> GetComponentAsync(int ComponentId)
        {
            return await this.GetAsync<ComponentResponse>($"components/{ComponentId}");
        }

        /// <summary>
        /// Gets the groups of components of the Cachet API.
        /// </summary>
        public ComponentGroupsResponse GetComponentGroups()
        {
            return this.Get<ComponentGroupsResponse>("components/groups");
        }

        /// <summary>
        /// Gets the groups of components of the Cachet API.
        /// </summary>
        public async Task<ComponentGroupsResponse> GetComponentGroupsAsync()
        {
            return await this.GetAsync<ComponentGroupsResponse>("components/groups");
        }

        /// <summary>
        /// Gets the specified group of components of the Cachet API.
        /// </summary>
        /// <param name="ComponentGroupId">The component group identifier.</param>
        public ComponentGroupsResponse GetComponentGroups(int ComponentGroupId)
        {
            return this.Get<ComponentGroupsResponse>($"components/groups/{ComponentGroupId}");
        }

        /// <summary>
        /// Gets the specified group of components of the Cachet API.
        /// </summary>
        /// <param name="ComponentGroupId">The component group identifier.</param>
        public async Task<ComponentGroupsResponse> GetComponentGroupsAsync(int ComponentGroupId)
        {
            return await this.GetAsync<ComponentGroupsResponse>($"components/groups/{ComponentGroupId}");
        }

        /// <summary>
        /// Gets a list of incidents from the Cachet API.
        /// </summary>
        public IncidentsResponse GetIncidents()
        {
            return this.Get<IncidentsResponse>("incidents");
        }

        /// <summary>
        /// Gets a list of incidents from the Cachet API.
        /// </summary>
        public async Task<IncidentsResponse> GetIncidentsAsync()
        {
            return await this.GetAsync<IncidentsResponse>("incidents");
        }

        /// <summary>
        /// Gets the specified incident from the Cachet API.
        /// </summary>
        /// <param name="IncidentId">The incident identifier.</param>
        public IncidentResponse GetIncident(int IncidentId)
        {
            return this.Get<IncidentResponse>($"incidents/{IncidentId}");
        }

        /// <summary>
        /// Gets the specified incident from the Cachet API.
        /// </summary>
        /// <param name="IncidentId">The incident identifier.</param>
        public async Task<IncidentResponse> GetIncidentAsync(int IncidentId)
        {
            return await this.GetAsync<IncidentResponse>($"incidents/{IncidentId}");
        }

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
        /// Gets the subscribers from the Cachet API.
        /// </summary>
        public SubscribersResponse GetSubscribers()
        {
            return this.Get<SubscribersResponse>("subscribers");
        }

        /// <summary>
        /// Gets the subscribers from the Cachet API.
        /// </summary>
        public async Task<SubscribersResponse> GetSubscribersAsync()
        {
            return await this.GetAsync<SubscribersResponse>("subscribers");
        }
    }
}
