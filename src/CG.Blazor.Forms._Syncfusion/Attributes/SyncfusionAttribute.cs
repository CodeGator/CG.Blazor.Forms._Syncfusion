using System;
using System.Collections.Generic;

namespace CG.Blazor.Forms.Attributes
{
    /// <summary>
    /// This class is a base for all Syncfusion specific form generation attributes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class SyncfusionAttribute : FormGeneratorAttribute
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        #endregion

        // *******************************************************************
        // Constructors.
        // *******************************************************************

        #region Constructors

        /// <summary>
        /// This constructor creates a new instance of <see cref="SyncfusionAttribute"/>
        /// class.
        /// </summary>
        protected SyncfusionAttribute()
        {
            // Set default values.
            
        }

        #endregion

        // *******************************************************************
        // Public methods.
        // *******************************************************************

        #region Public methods

        /// <inheritdoc/>
        public override IDictionary<string, object> ToAttributes()
        {
            // Create a table to hold the attributes.
            var attr = base.ToAttributes();

            // Return the attributes.
            return attr;
        }

        #endregion
    }
}
