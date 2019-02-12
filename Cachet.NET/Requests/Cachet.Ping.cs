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
    }
}
