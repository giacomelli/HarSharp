using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Describes timings for various events (states) fired during the page load.
    /// <remarks>
    /// All times are specified in milliseconds.
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-pageTimings" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("OnContentLoad: {OnContentLoad} | OnLoad: {OnLoad}")]
    public class PageTimings : EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the number of milliseconds since page load started when the content is loaded.
        /// </summary>
        public double? OnContentLoad { get; set; }

        /// <summary>
        /// Gets or sets the number of milliseconds since page load started when the page is loaded. 
        /// </summary>
        public double? OnLoad { get; set; }
        #endregion
    }
}
