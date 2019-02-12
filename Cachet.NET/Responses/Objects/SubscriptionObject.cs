namespace Cachet.NET.Responses.Objects
{
    using System;

    public class SubscriptionObject
    {
        public int Id
        {
            get;
            set;
        }

        public int SubscriberId
        {
            get;
            set;
        }

        public int ComponentId
        {
            get;
            set;
        }

        public DateTime CreatedAt
        {
            get;
            set;
        }

        public DateTime UpdatedAt
        {
            get;
            set;
        }
    }
}
