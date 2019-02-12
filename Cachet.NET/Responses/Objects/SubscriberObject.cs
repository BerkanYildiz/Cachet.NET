namespace Cachet.NET.Responses.Objects
{
    using System;
    using System.Collections.Generic;

    public class SubscriberObject
    {
        public int Id
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string VerifyCode
        {
            get;
            set;
        }

        public DateTime? VerifiedAt
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

        public bool Global
        {
            get;
            set;
        }

        public List<SubscriptionObject> Subscriptions
        {
            get;
            set;
        }
    }
}
