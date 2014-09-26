using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Describes details about response content.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-content" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("{MimeType}: {Text}")]
    public class Content : EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the length of the returned content in bytes.
        /// <remarks>
        /// Should be equal to response.BodySize if there is no compression and bigger when the content has been compressed.
        /// </remarks>
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the number of bytes saved.
        /// </summary>
        public int? Compression { get; set; }

        /// <summary>
        /// Gets or sets the MIME type of the response text (value of the Content-Type response header). 
        /// <remarks>
        /// The charset attribute of the MIME type is included (if available).
        /// </remarks>
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets the response body sent from the server or loaded from the browser cache.
        /// <remarks>
        /// This field is populated with textual content only. The text field is either HTTP decoded text or a encoded (e.g. "base64") representation of the response body.
        /// </remarks>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the encoding used for response text field.
        /// </summary>
        public string Encoding { get; set; }
        #endregion
    }
}
