namespace Cachet.NET.Responses.Objects
{
    using System;

    public class MetricObject
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Suffix
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public int DefaultValue
        {
            get;
            set;
        }

        public int CalcType
        {
            get;
            set;
        }

        public bool DisplayChart
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

        public int Places
        {
            get;
            set;
        }

        public int DefaultView
        {
            get;
            set;
        }

        public int Threshold
        {
            get;
            set;
        }

        public int Order
        {
            get;
            set;
        }

        public string DefaultViewName
        {
            get;
            set;
        }
    }
}
