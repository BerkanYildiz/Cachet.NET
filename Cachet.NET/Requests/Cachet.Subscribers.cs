namespace Cachet.NET
{
    using System;
    using System.Threading.Tasks;

    using global::Cachet.NET.Responses;

    public partial class Cachet : IDisposable
    {
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
