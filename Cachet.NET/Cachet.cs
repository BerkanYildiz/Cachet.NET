namespace Cachet.NET
{
    using System.Threading.Tasks;

    using global::Cachet.NET.Responses;

    using RestSharp;
    using RestSharp.Authenticators;

    public class Cachet
    {
        /// <summary>
        /// Gets a value indicating whether this instance is filled.
        /// </summary>
        private bool Initialized
        {
            get;
        }

        private readonly string Hostname;
        private readonly string ApiKey;

        private RestClient Rest;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cachet"/> class.
        /// </summary>
        /// <param name="Host">The host.</param>
        /// <param name="ApiKey">The API key.</param>
        public Cachet(string Host, string ApiKey)
        {
            this.Hostname       = Host;
            this.ApiKey         = ApiKey;

            this.Rest           = new RestClient(Host);
            this.Rest.AddDefaultHeader("X-Cachet-Token", ApiKey);

            this.Initialized    = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cachet"/> class.
        /// </summary>
        /// <param name="Host">The host.</param>
        /// <param name="Email">The email.</param>
        /// <param name="Password">The password.</param>
        public Cachet(string Host, string Email, string Password)
        {
            this.Hostname       = Host;
            this.ApiKey         = ApiKey;

            this.Rest           = new RestClient(Host)
            {
                Authenticator   = new HttpBasicAuthenticator(Email, Password)
            };

            this.Initialized    = true;
        }

        /// <summary>
        /// Pings the Cachet API.
        /// </summary>
        public bool Ping()
        {
            if (this.Initialized == false)
            {
                return false;
            }

            var Request  = new RestRequest("ping");
            var Response = this.Rest.Get<PingResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var PingResponse = Response.Data;

                if (PingResponse.IsValid)
                {
                    return true;
                }
            }

            return false;
        }
        
        /// <summary>
        /// Pings the Cachet API.
        /// </summary>
        public async Task<bool> PingAsync()
        {
            if (this.Initialized == false)
            {
                return false;
            }

            var Request  = new RestRequest("ping");
            var Response = await this.Rest.ExecuteGetTaskAsync<PingResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var PingResponse = Response.Data;

                if (PingResponse.IsValid)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the version of the Cachet API.
        /// </summary>
        public VersionResponse GetVersion()
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("version");
            var Response = this.Rest.Get<VersionResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var VersionResponse = Response.Data;

                if (VersionResponse != null)
                {
                    return VersionResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the version of the Cachet API.
        /// </summary>
        public async Task<VersionResponse> GetVersionAsync()
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("version");
            var Response = await this.Rest.ExecuteGetTaskAsync<VersionResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var VersionResponse = Response.Data;

                if (VersionResponse != null)
                {
                    return VersionResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the components of the Cachet API.
        /// </summary>
        public ComponentsResponse GetComponents()
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("components");
            var Response = this.Rest.Get<ComponentsResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var ComponentsResponse = Response.Data;

                if (ComponentsResponse != null)
                {
                    return ComponentsResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the components of the Cachet API.
        /// </summary>
        public async Task<ComponentsResponse> GetComponentsAsync()
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("components");
            var Response = await this.Rest.ExecuteGetTaskAsync<ComponentsResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var ComponentsResponse = Response.Data;

                if (ComponentsResponse != null)
                {
                    return ComponentsResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the specified component of the Cachet API.
        /// </summary>
        /// <param name="ComponentId">The component identifier.</param>
        public ComponentResponse GetComponent(int ComponentId)
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("components/{componentId}").AddUrlSegment("componentId", ComponentId);
            var Response = this.Rest.Get<ComponentResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var ComponentResponse = Response.Data;

                if (ComponentResponse != null)
                {
                    return ComponentResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the specified component of the Cachet API.
        /// </summary>
        /// <param name="ComponentId">The component identifier.</param>s
        public async Task<ComponentResponse> GetComponentAsync(int ComponentId)
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("components/{componentId}").AddUrlSegment("componentId", ComponentId);
            var Response = await this.Rest.ExecuteGetTaskAsync<ComponentResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var ComponentResponse = Response.Data;

                if (ComponentResponse != null)
                {
                    return ComponentResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the groups of components of the Cachet API.
        /// </summary>
        public ComponentGroupsResponse GetComponentGroups()
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("components/groups");
            var Response = this.Rest.Get<ComponentGroupsResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var ComponentGroupsResponse = Response.Data;

                if (ComponentGroupsResponse != null)
                {
                    return ComponentGroupsResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the groups of components of the Cachet API.
        /// </summary>
        public async Task<ComponentGroupsResponse> GetComponentGroupsAsync()
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("components/groups");
            var Response = await this.Rest.ExecuteGetTaskAsync<ComponentGroupsResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var ComponentGroupsResponse = Response.Data;

                if (ComponentGroupsResponse != null)
                {
                    return ComponentGroupsResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the specified group of components of the Cachet API.
        /// </summary>
        /// <param name="ComponentGroupId">The component group identifier.</param>
        public ComponentGroupsResponse GetComponentGroups(int ComponentGroupId)
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("components/groups/{componentGroupId}").AddUrlSegment("componentGroupId", ComponentGroupId);
            var Response = this.Rest.Get<ComponentGroupsResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var ComponentGroupsResponse = Response.Data;

                if (ComponentGroupsResponse != null)
                {
                    return ComponentGroupsResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the specified group of components of the Cachet API.
        /// </summary>
        /// <param name="ComponentGroupId">The component group identifier.</param>
        public async Task<ComponentGroupsResponse> GetComponentGroupsAsync(int ComponentGroupId)
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request  = new RestRequest("components/groups/{componentGroupId}").AddUrlSegment("componentGroupId", ComponentGroupId);
            var Response = this.Rest.Get<ComponentGroupsResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var ComponentGroupsResponse = Response.Data;

                if (ComponentGroupsResponse != null)
                {
                    return ComponentGroupsResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets a list of incidents from the Cachet API.
        /// </summary>
        public IncidentsResponse GetIncidents()
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request = new RestRequest("incidents");
            var Response = this.Rest.Get<IncidentsResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var incidentsResponse = Response.Data;

                if (incidentsResponse != null)
                {
                    return incidentsResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the Incidents of the Cachet API.
        /// </summary>
        public async Task<IncidentsResponse> GetIncidentsAsync()
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request = new RestRequest("incidents");
            var Response = await this.Rest.ExecuteGetTaskAsync<IncidentsResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var incidentsResponse = Response.Data;

                if (incidentsResponse != null)
                {
                    return incidentsResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the specified Incident of the Cachet API.
        /// </summary>
        /// <param name="IncidentId">The Incident identifier.</param>
        public IncidentResponse GetIncident(int IncidentId)
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request = new RestRequest("incidents/{incidentId}").AddUrlSegment("incidentId", IncidentId);
            var Response = this.Rest.Get<IncidentResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var IncidentResponse = Response.Data;

                if (IncidentResponse != null)
                {
                    return IncidentResponse;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the specified Incident of the Cachet API.
        /// </summary>
        /// <param name="IncidentId">The Incident identifier.</param>s
        public async Task<IncidentResponse> GetIncidentAsync(int IncidentId)
        {
            if (this.Initialized == false)
            {
                return null;
            }

            var Request = new RestRequest("incidents/{incidentId}").AddUrlSegment("incidentId", IncidentId);
            var Response = await this.Rest.ExecuteGetTaskAsync<IncidentResponse>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                var IncidentResponse = Response.Data;

                if (IncidentResponse != null)
                {
                    return IncidentResponse;
                }
            }

            return null;
        }

    }
}
