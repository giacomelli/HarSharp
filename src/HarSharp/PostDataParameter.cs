namespace HarSharp
{
    /// <summary>
    /// Represents a posted data.
    /// </summary>
    public class PostDataParameter : ParameterBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets name of a posted file.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets content type of a posted file.
        /// </summary>
        public string ContentType { get; set; }
        #endregion
    }
}
