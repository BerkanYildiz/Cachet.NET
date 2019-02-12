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
            return this.Get<ComponentResponse>("components/{componentId}", "componentId", ComponentId.ToString());
        }

        /// <summary>
        /// Gets the specified component of the Cachet API.
        /// </summary>
        /// <param name="ComponentId">The component identifier.</param>s
        public async Task<ComponentResponse> GetComponentAsync(int ComponentId)
        {
            return await this.GetAsync<ComponentResponse>("components/{componentId}", "componentId", ComponentId.ToString());
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
            return this.Get<ComponentGroupsResponse>("components/groups/{componentGroupId}", "componentGroupId", ComponentGroupId.ToString());
        }

        /// <summary>
        /// Gets the specified group of components of the Cachet API.
        /// </summary>
        /// <param name="ComponentGroupId">The component group identifier.</param>
        public async Task<ComponentGroupsResponse> GetComponentGroupsAsync(int ComponentGroupId)
        {
            return await this.GetAsync<ComponentGroupsResponse>("components/groups/{componentGroupId}", "componentGroupId", ComponentGroupId.ToString());
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
            return this.Get<IncidentResponse>("incidents/{incidentId}", "incidentId", IncidentId.ToString());
        }

        /// <summary>
        /// Gets the specified Incident of the Cachet API.
        /// </summary>
        /// <param name="IncidentId">The Incident identifier.</param>s
        public async Task<IncidentResponse> GetIncidentAsync(int IncidentId)
        {
            return await this.GetAsync<IncidentResponse>("incidents/{incidentId}", "incidentId", IncidentId.ToString());
        }
    }
}
