﻿namespace Cachet.NET
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    using RestSharp;
    using RestSharp.Authenticators;

    public partial class Cachet : IDisposable
    {
        /// <summary>
        /// Gets or sets the restsharp client.
        /// </summary>
        private RestClient Rest
        {
            get;
        }

        /// <summary>
        /// Removes or adds an event fired when this instance has been disposed (AFTER being disposed).
        /// </summary>
        public EventHandler OnDisposed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is disposed.
        /// </summary>
        public bool IsDisposed
        {
            get;
            private set;
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="Cachet"/> class from being created.
        /// </summary>
        private Cachet()
        {
            // Cachet
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
            var Request = new RestRequest(Uri);
            var Response = this.Rest.Get<T>(Request);

            #if DEBUG

            Log.Warning(typeof(Cachet), "Response : ");
            Log.Warning(typeof(Cachet), " - Content : " + Response.Content);
            Log.Warning(typeof(Cachet), " - Status  : " + Response.ResponseStatus);
            Log.Warning(typeof(Cachet), " - Code    : " + Response.StatusCode);
            Log.Warning(typeof(Cachet), " - ------- : " + "----------------------");

            #endif

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.Data;
            }

            return null;
        }

        /// <summary>
        /// Gets data from the specified endpoint asynchronously.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        private async Task<T> GetAsync<T>(string Uri) where T : class, new()
        {
            var Request = new RestRequest(Uri);
            var Response = await this.Rest.ExecuteGetTaskAsync<T>(Request);

            #if DEBUG

            Log.Warning(typeof(Cachet), "Response : ");
            Log.Warning(typeof(Cachet), " - Content : " + Response.Content);
            Log.Warning(typeof(Cachet), " - Status  : " + Response.ResponseStatus);
            Log.Warning(typeof(Cachet), " - Code    : " + Response.StatusCode);
            Log.Warning(typeof(Cachet), " - ------- : " + "----------------------");

            #endif

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.Data;
            }

            return null;
        }

        /// <summary>
        /// Gets data from the specified endpoint asynchronously.
        /// </summary>
        /// <param name="Uri">The URI.</param>
        /// <param name="Token">The cancellation token.</param>
        private async Task<T> GetAsync<T>(string Uri, CancellationToken Token) where T : class, new()
        {
            var Request = new RestRequest(Uri);
            var Response = await this.Rest.ExecuteGetTaskAsync<T>(Request, Token);

            #if DEBUG

            Log.Warning(typeof(Cachet), "Response : ");
            Log.Warning(typeof(Cachet), " - Content : " + Response.Content);
            Log.Warning(typeof(Cachet), " - Status  : " + Response.ResponseStatus);
            Log.Warning(typeof(Cachet), " - Code    : " + Response.StatusCode);
            Log.Warning(typeof(Cachet), " - ------- : " + "----------------------");

            #endif

            if (Response.ResponseStatus == ResponseStatus.Completed)
            {
                return Response.Data;
            }

            return null;
        }

        /// <summary>
        /// Exécute les tâches définies par l'application associées à la
        /// libération ou à la redéfinition des ressources non managées.
        /// </summary>
        public void Dispose()
        {
            if (this.IsDisposed)
            {
                return;
            }

            this.IsDisposed = true;

            // ..

            // Dispose the used instances..

            // ..

            if (this.OnDisposed != null)
            {
                try
                {
                    this.OnDisposed.Invoke(this, EventArgs.Empty);
                }
                catch (Exception)
                {
                    // ..
                }
            }
        }
    }
}
