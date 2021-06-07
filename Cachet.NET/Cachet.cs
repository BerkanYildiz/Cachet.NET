namespace Cachet.NET
{
    using System.Threading;
    using System.Threading.Tasks;

    using RestSharp;
    using RestSharp.Authenticators;

    public partial class Cachet
    {
        /// <summary>
        /// Gets or sets the restsharp client.
        /// </summary>
        private RestClient Rest
        {
            get;
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="Cachet"/> class from being created.
        /// </summary>
        private Cachet()
        {
            // ...
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cachet"/> class.
        /// Leave the ApiKey argument empty if using the demo API.
        /// </summary>
        /// <param name="Host">The host.</param>
        /// <param name="ApiKey">The API key .</param>
        public Cachet(string Host, string ApiKey = "")
        {
            this.Rest = new RestClient(Host);

            if (!string.IsNullOrEmpty(ApiKey))
            {
                this.Rest.AddDefaultHeader("X-Cachet-Token", ApiKey);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cachet"/> class.
        /// </summary>
        /// <param name="Host">The host.</param>
        /// <param name="Email">The email.</param>
        /// <param name="Password">The password.</param>
        public Cachet(string Host, string Email, string Password)
        {
            this.Rest = new RestClient(Host)
            {
                Authenticator = new HttpBasicAuthenticator(Email, Password)
            };
        }

        /// <summary>
        /// Gets data from the specified endpoint.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        private T Get<T>(string Uri) where T : class, new()
        {
            var Request = new RestRequest(Uri, Method.GET);
            var Response = this.Rest.Execute<T>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.Data;
            }

            return null;
        }

        /// <summary>
        /// Posts and gets data from the specified endpoint.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        /// <param name="Body">The post request body.</param>
        private T Post<T>(string Uri, dynamic Body = null) where T : class, new()
        {
            var Request = new RestRequest(Uri, Method.POST);

            if (Body != null)
            {
                Request.AddJsonBody((object) Body);
            }

            var Response = this.Rest.Execute<T>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.Data;
            }

            return null;
        }

        /// <summary>
        /// Deletes data at the specified endpoint.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        private bool Delete(string Uri)
        {
            var Request = new RestRequest(Uri, Method.DELETE);
            var Response = this.Rest.Execute(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.IsSuccessful;
            }

            return false;
        }

        /// <summary>
        /// Gets data from the specified endpoint asynchronously.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        private async Task<T> GetAsync<T>(string Uri) where T : class, new()
        {
            var Request = new RestRequest(Uri, Method.GET);
            var Response = await this.Rest.ExecuteAsync<T>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.Data;
            }

            return null;
        }

        /// <summary>
        /// Posts and gets data from the specified endpoint asynchronously.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        /// <param name="Body">The post request body.</param>
        private async Task<T> PostAsync<T>(string Uri, dynamic Body = null) where T : class, new()
        {
            var Request = new RestRequest(Uri, Method.POST);

            if (Body != null)
            {
                Request.AddJsonBody((object) Body);
            }

            var Response = await this.Rest.ExecuteAsync<T>(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.Data;
            }

            return null;
        }

        /// <summary>
        /// Deletes data at the specified endpoint asynchronously.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        private async Task<bool> DeleteAsync(string Uri)
        {
            var Request = new RestRequest(Uri, Method.DELETE);
            var Response = await this.Rest.ExecuteAsync(Request);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.IsSuccessful;
            }

            return false;
        }

        /// <summary>
        /// Gets data from the specified endpoint asynchronously.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        /// <param name="Token">The cancellation token.</param>
        private async Task<T> GetAsync<T>(string Uri, CancellationToken Token) where T : class, new()
        {
            var Request = new RestRequest(Uri, Method.GET);
            var Response = await this.Rest.ExecuteAsync<T>(Request, Token);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.Data;
            }

            return null;
        }

        /// <summary>
        /// Posts and gets data from the specified endpoint asynchronously.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        /// <param name="Token">The cancellation token.</param>
        /// <param name="Body">The post request body.</param>
        private async Task<T> PostAsync<T>(string Uri, CancellationToken Token, dynamic Body = null) where T : class, new()
        {
            var Request = new RestRequest(Uri, Method.POST);

            if (Body != null)
            {
                Request.AddJsonBody((object)Body);
            }

            var Response = await this.Rest.ExecuteAsync<T>(Request, Token);

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.Data;
            }

            return null;
        }
    }
}
