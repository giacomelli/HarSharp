using System;

namespace HarSharp
{
    /// <summary>
    /// Represents a HTTP cookie.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-cookies" />
    /// </remarks>
    /// </summary>
    public class Cookie : ParameterBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the path pertaining to the cookie.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the host of the cookie.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the cookie expiration time.
        /// </summary>
        public DateTime? Expires { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is HTTP only.
        /// </summary>
        public bool HttpOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it was transmitted over SSL.
        /// </summary>
        public bool Secure { get; set; }
        #endregion
    }
}
