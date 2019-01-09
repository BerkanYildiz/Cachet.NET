namespace Cachet.NET.Responses.Objects
{
    /// <summary>
    /// Available Component status values from https://docs.cachethq.io/v1.0/docs/component-statuses
    /// </summary>
    public enum ComponentStatus : int
    {
        /// <summary>
        /// The component is working.
        /// </summary>
        Operational = 1,
        /// <summary>
        /// The component is experiencing some slowness.
        /// </summary>
        PerformanceIssues = 2,
        /// <summary>
        /// The component may not be working for everybody. This could be a geographical issue for example.
        /// </summary>
        PartialOutage = 3,
        /// <summary>
        /// The component is not working for anybody.
        /// </summary>
        MajorOutage = 4
    }
}