namespace Cachet.NET.Responses
{
    public class PingResponse
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public string Data
        {
            get;
            set;
        }

        /// <summary>
        /// Returns true if the ping is valid.
        /// </summary>
        public bool IsValid
        {
            get
            {
                return Data?.StartsWith("Pong") ?? false;
            }
        }
    }
}
