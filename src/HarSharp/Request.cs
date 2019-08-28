using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Contains detailed info about performed request.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-request" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("{Method} {Url}")]
    public class Request : MessageBase
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Request"/> class.
        /// </summary>
        public Request()
        {
            QueryString = new List<QueryStringParameter>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the method (GET, POST, ...).
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the absolute URL (fragments are not included).
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Gets the list of query parameter objects.
        /// </summary>
        public IList<QueryStringParameter> QueryString { get; private set; }

        /// <summary>
        /// Gets or sets the posted data info.
        /// </summary>
        public PostData PostData { get; set; }
        #endregion
    }
}
