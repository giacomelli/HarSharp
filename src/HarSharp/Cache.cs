using System.Diagnostics.CodeAnalysis;

namespace HarSharp
{
    /// <summary>
    /// Contains information about a request coming from browser cache.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-cache" />
    /// </remarks>
    /// </summary>
    [SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces", Justification = "This is the name on W3C spec.")]
    public class Cache : EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the state of a cache entry before the request.
        /// </summary>
        public CacheState BeforeRequest { get; set; }

        /// <summary>
        /// Gets or sets the state of a cache entry after the request.
        /// </summary>
        public CacheState AfterRequest { get; set; }
        #endregion
    }
}
