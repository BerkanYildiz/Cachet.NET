namespace Cachet.NET.Responses.Objects
{
    using System;

    public class ComponentGroupObject
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

        public int Order
        {
            get;
            set;
        }

        public int Collapsed
        {
            get;
            set;
        }
    }
}
