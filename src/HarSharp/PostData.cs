using System.Collections.Generic;
using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// Describes posted data.
    /// <remarks>
    /// <see cref="!:https://dvcs.w3.org/hg/webperf/raw-file/tip/specs/HAR/Overview.html#sec-object-types-postData" />
    /// </remarks>
    /// </summary>
    [DebuggerDisplay("{MimeType}: {Text}")]
    public class PostData : EntityBase
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="PostData"/> class.
        /// </summary>
        public PostData()
        {
            Params = new List<PostDataParameter>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the mime type of posted data.
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Gets the list of posted parameters (in case of URL encoded parameters).
        /// </summary>
        public IList<PostDataParameter> Params { get; private set; }

        /// <summary>
        /// Gets or sets the plain text posted data.
        /// </summary>
        public string Text { get; set; }
        #endregion
    }
}