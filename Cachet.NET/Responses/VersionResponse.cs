namespace Cachet.NET.Responses
{
    public class VersionResponse
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
        /// Gets or sets the data.
        /// </summary>
        public string Data
        {
            get;
            set;
        }

        public class MetaObject
        {
            /// <summary>
            /// Gets or sets a value indicating whether this version is the latest.
            /// </summary>
            public bool OnLatest
            {
                get;
                set;
            }

            /// <summary>
            /// Gets or sets the <see cref="LatestObject"/>.
            /// </summary>
            public LatestObject Latest
            {
                get;
                set;
            }

            public class LatestObject
            {
                /// <summary>
                /// Gets or sets the name of the tag.
                /// </summary>
                public string TagName
                {
                    get;
                    set;
                }

                /// <summary>
                /// Gets or sets a value indicating whether this version is a pre-release.
                /// </summary>
                public bool PreRelease
                {
                    get;
                    set;
                }

                /// <summary>
                /// Gets or sets a value indicating whether this version is draft.
                /// </summary>
                public bool Draft
                {
                    get;
                    set;
                }
            }
        }
    }
}
