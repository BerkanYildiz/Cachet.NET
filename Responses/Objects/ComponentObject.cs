namespace Cachet.NET.Responses.Objects
{
    using System;
    using System.Collections.Generic;

    public class ComponentObject
    {
        public int Identifier
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Link
        {
            get;
            set;
        }

        public int Status
        {
            get;
            set;
        }

        public int Order
        {
            get;
            set;
        }

        public int GroupId
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

        public DateTime? DeletedAt
        {
            get;
            set;
        }

        public string StatusName
        {
            get;
            set;
        }

        public Dictionary<string, string> Tags
        {
            get;
            set;
        }
    }
}
