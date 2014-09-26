using System.Diagnostics;

namespace HarSharp
{
    /// <summary>
    /// A base class for parameters.
    /// </summary>
    [DebuggerDisplay("{Name} = {Value}")]
    public abstract class ParameterBase : EntityBase
    {
        #region Properties
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string Value { get; set; }
        #endregion
    }
}