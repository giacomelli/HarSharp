using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Contains information about the log creator application.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-creator" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("{Name} ({Version})")]
    public class Creator : EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        public string Version { get; set; }
        #endregion
    }
}
