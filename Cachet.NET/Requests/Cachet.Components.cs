namespace Cachet.NET
{
    using System;
    using System.Threading.Tasks;

    using global::Cachet.NET.Responses;

    public partial class Cachet : IDisposable
    {
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
    }
}
