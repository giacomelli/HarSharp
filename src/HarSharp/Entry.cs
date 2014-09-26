using System;
using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Represents one exported (tracked) HTTP request.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-har-object-types-entry" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("{PageRef}: {StartedDateTime}")]
    public class Entry : EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the reference to the parent page.
        /// </summary>
        public string PageRef { get; set; }

        /// <summary>
        /// Gets or sets the date and time of the request start.
        /// </summary>
        public DateTime StartedDateTime { get; set; }

        /// <summary>
        /// Gets or sets the total elapsed time of the request in milliseconds.
        /// <remarks>
        /// This is the sum of all timings available in the timings object.
        /// </remarks>
        /// </summary>
        public double Time { get; set; }

        /// <summary>
        /// Gets or sets the detailed info about the request.
        /// </summary>
        public Request Request { get; set; }

        /// <summary>
        /// Gets or sets the detailed info about the response.
        /// </summary>
        public Response Response { get; set; }

        /// <summary>
        /// Gets or sets the info about cache usage.
        /// </summary>
        public Cache Cache { get; set; }

        /// <summary>
        /// Gets or sets the detailed timing info about request/response round trip.
        /// </summary>
        public Timings Timings { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the server that was connected (result of DNS resolution).
        /// </summary>
        public string ServerIPAddress { get; set; }

        /// <summary>
        /// Gets or sets the Unique ID of the parent TCP/IP connection, can be the client port number. 
        /// <remarks>
        /// Note that a port number doesn't have to be unique identifier in cases where the port is shared for more connections. 
        /// If the port isn't available for the application, any other unique connection ID can be used instead (e.g. connection index).
        /// </remarks>
        /// </summary>
        public string Connection { get; set; }
        #endregion
    }
}
