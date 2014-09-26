namespace HarSharp
{
    /// <summary>
    /// A base class for all HAR entities.
    /// </summary>
    public abstract class EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets a comment provided by the user or the application.
        /// </summary>
        public string Comment { get; set; }
        #endregion
    }
}
