using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Describes various phases within request-response round trip.
    /// <remarks>
    /// All times are specified in milliseconds.
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-timings" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("Blocked:{Blocked} | Dns:{Dns} | Connect:{Connect} | Send:{Send} | Wait:{Wait} | Receive:{Receive} | Ssl:{Ssl}")]
    public class Timings : EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the time spent in a queue waiting for a network connection.
        /// </summary>
        public double? Blocked { get; set; }

        /// <summary>
        /// Gets or sets the DNS resolution time. The time required to resolve a host name. 
        /// </summary>
        public double? Dns { get; set; }

        /// <summary>
        /// Gets or sets the time required to create TCP connection.
        /// </summary>
        public double? Connect { get; set; }

        /// <summary>
        /// Gets or sets the time required to send HTTP request to the server.
        /// </summary>
        public double Send { get; set; }

        /// <summary>
        /// Gets or sets the waiting for a response from the server.
        /// </summary>
        public double Wait { get; set; }

        /// <summary>
        /// Gets or sets the time required to read entire response from the server (or cache).
        /// </summary>
        public double Receive { get; set; }

        /// <summary>
        /// Gets or sets the time required for SSL/TLS negotiation.
        /// </summary>
        public double? Ssl { get; set; }
        #endregion
    }
}
