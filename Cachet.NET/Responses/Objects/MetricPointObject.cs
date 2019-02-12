namespace Cachet.NET.Responses.Objects
{
    using System;

    public class MetricPointObject
    {
        public int Id
        {
            get;
            set;
        }

        public int MetricId
        {
            get;
            set;
        }

        public int Value
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

        public int Counter
        {
            get;
            set;
        }

        public int CalculatedValue
        {
            get;
            set;
        }
    }
}
