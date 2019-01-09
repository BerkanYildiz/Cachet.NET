namespace Cachet.NET.Responses.Objects
{
    /// <summary>
    /// Available Incident status values from https://docs.cachethq.io/docs/incident-statuses
    /// </summary>
    public enum IncidentStatus : int
    {
        /// <summary>
        /// This status is reserved for a scheduled status.
        /// </summary>
        Scheduled = 0,
        /// <summary>
        /// You have reports of a problem and you're currently looking into them.
        /// </summary>
        Investigating = 1,
        /// <summary>
        /// You've found the issue and you're working on a fix.
        /// </summary>
        Identified = 2,
        /// <summary>
        /// You've since deployed a fix and you're currently watching the situation.
        /// </summary>
        Watching = 3,
        /// <summary>
        /// The fix has worked, you're happy to close the incident.
        /// </summary>
        Fixed = 4
    }
}