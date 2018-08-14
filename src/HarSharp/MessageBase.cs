using System.Collections.Generic;

namespace HarSharp
{
    /// <summary>
    /// A base class for HTTP messages.
    /// </summary>
    public abstract class MessageBase : EntityBase
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBase"/> class.
        /// </summary>
        protected MessageBase()
        {
            Cookies = new List<Cookie>();
            Headers = new List<Header>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the HTTP Version.
        /// </summary>
        public string HttpVersion { get; set; }

        /// <summary>
        /// Gets the list of cookie objects.
        /// </summary>
        public IList<Cookie> Cookies { get; private set; }

        /// <summary>
        /// Gets the list of header objects.
        /// </summary>
        public IList<Header> Headers { get; private set; }

        /// <summary>
        /// Gets or sets the total number of bytes from the start of the HTTP request message until (and including) the double CRLF before the body.
        /// </summary>
        public int HeadersSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the request body (POST data payload) in bytes. 
        /// </summary>
        public int? BodySize { get; set; }
        #endregion
    }
}
