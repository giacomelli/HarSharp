using System;
using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Represents a cache state.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-cache" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("HitCount: {HitCount}")]
    public class CacheState : EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the expiration time of the cache entry.
        /// </summary>
        public DateTime Expires { get; set; }

        /// <summary>
        /// Gets or sets the last time the cache entry was opened.
        /// </summary>
        public DateTime LastAccess { get; set; }

        /// <summary>
        /// Gets or sets the ETag.
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the number of times the cache entry has been opened.
        /// </summary>
        public int HitCount { get; set; }
        #endregion
    }
}
