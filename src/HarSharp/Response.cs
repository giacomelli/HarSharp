using System;
using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Contains detailed info about the response.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-response" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("{Status} ({StatusText})")]
    public class Response : MessageBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the HTTP status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the HTTP status description.
        /// </summary>
        public string StatusText { get; set; }

        /// <summary>
        /// Gets or sets the details about the response body.
        /// </summary>
        public Content Content { get; set; }

        /// <summary>
        /// Gets or sets the redirection target URL from the Location response header.
        /// </summary>
        public Uri RedirectUrl { get; set; }
        #endregion
    }
}
