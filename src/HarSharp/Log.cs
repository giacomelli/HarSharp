using System.Collections.Generic;
using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Represents the root of the HAR data.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-log" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("Pages: {Pages.Count} | Entries: {Entries.Count}")]
    public class Log : EntityBase
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        public Log()
        {
            Pages = new List<Page>();
            Entries = new List<Entry>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the version number of the format.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the log creator application. 
        /// </summary>
        public Creator Creator { get; set; }

        /// <summary>
        /// Gets or sets the user agent.
        /// </summary>
        public Browser Browser { get; set; }

        /// <summary>
        /// Gets the pages.
        /// </summary>
        public IList<Page> Pages { get; private set; }

        /// <summary>
        /// Gets the entries.
        /// </summary>
        public IList<Entry> Entries { get; private set; }
        #endregion
    }
}
