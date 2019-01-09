namespace Cachet.NET.Responses
{
    using global::Cachet.NET.Responses.Objects;

    using RestSharp.Deserializers;

    public class IncidentResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="MetaObject"/>.
        /// </summary>
        public MetaObject Meta
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Incident.
        /// </summary>
        [DeserializeAs(Name = "data")]
        public IncidentObject Incident
        {
            get;
            set;
        }

        public class MetaObject
        {
            /// <summary>
            /// Gets or sets the pagination.
            /// </summary>
            public PaginationObject Pagination
            {
                get;
                set;
            }

            public class PaginationObject
            {
                public int Total
                {
                    get;
                    set;
                }

                public int Count
                {
                    get;
                    set;
                }

                public int PerPage
                {
                    get;
                    set;
                }

                public int CurrentPage
                {
                    get;
                    set;
                }

                public int TotalPages
                {
                    get;
                    set;
                }

                public LinksObject Links
                {
                    get;
                    set;
                }

                public class LinksObject
                {
                    public int NextPage
                    {
                        get;
                        set;
                    }

                    public int PreviousPage
                    {
                        get;
                        set;
                    }
                }
            }
        }
    }
}
