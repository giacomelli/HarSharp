using System;
using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Represents a tracked page.
    /// </summary>
    [DebuggerDisplay("{Id} - {Title}: {StartedDateTime}")]
    public class Page : EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the tate and time for the beginning of the page load.
        /// </summary>
        public DateTime StartedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of a page.
        /// <remarks>
        /// Entries use it to refer the parent page.
        /// </remarks>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the detailed timing info about page load.
        /// </summary>
        public PageTimings PageTimings { get; set; }
        #endregion
    }
}
