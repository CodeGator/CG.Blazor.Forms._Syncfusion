using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CG.Blazor.Forms.Services;
using CG.Validations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.CompilerServices;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor.Buttons;

namespace CG.Blazor.Forms.Attributes
{
    /// <summary>
    /// This class is an attribute that, when applied to a <see cref="bool"/> property, 
    /// causes the form generator to render the property as a <see cref="SfCheckBox{T}"/> 
    /// component.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This attribute is only valid when placed on a property of type: <see cref="bool"/>.
    /// </para>
    /// </remarks>
    /// <example>
    /// Here is an example of decorating a model property to render a  <see cref="SfCheckBox{T}"/>:
    /// <code>
    /// using CG.Blazor.Forms.Attributes;
    /// class MyModel
    /// {
    ///     [RenderSfCheckBox]
    ///     public bool MyProperty { get;set; }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Property)]
    public class RenderSfCheckBoxAttribute : SyncfusionAttribute
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This property specifies a value to enable/disable tri state functionality 
        /// in CheckBox.
        /// </summary>
        public bool EnableTriState { get; set; }

        /// <summary>
        /// This property specifies a value that indicates whether the CheckBox is in 
        /// indeterminate state or not. When set to true, the CheckBox will be in 
        /// indeterminate state.
        /// </summary>
        public bool Indeterminate { get; set; }

        /// <summary>
        /// This property specifies the caption for the CheckBox, that describes the 
        /// purpose of the CheckBox.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// This property positions label before/after the CheckBox. The possible 
        /// values are:
        /// <list type="bullet">
        /// <item>Before - The label is positioned to left of the CheckBox.</item>
        /// <item>After - The label is positioned to right of the CheckBox.</item>
        /// </list>
        /// </summary>
        public LabelPosition LabelPosition { get; set; }

        #endregion

        // *******************************************************************
        // Constructors.
        // *******************************************************************

        #region Constructors

        /// <summary>
        /// This constrctor creates a new instance of the <see cref="RenderSfCheckBoxAttribute"/>
        /// class.
        /// </summary>
        public RenderSfCheckBoxAttribute()
        {
            // Set default values.
            EnableTriState = false;
            Indeterminate = false;
            Label = string.Empty;
            LabelPosition = LabelPosition.After;
        }

        #endregion

        // *******************************************************************
        // Public methods.
        // *******************************************************************

        #region Public methods

        /// <inheritdoc/>
        public override IDictionary<string, object> ToAttributes()
        {
            // Give the base class a chance.
            var attr = base.ToAttributes();

            // Does this property have a non-default value?
            if (false != EnableTriState)
            {
                // Add the property value.
                attr[nameof(EnableTriState)] = EnableTriState;
            }

            // Does this property have a non-default value?
            if (false != Indeterminate)
            {
                // Add the property value.
                attr[nameof(Indeterminate)] = Indeterminate;
            }

            // Does this property have a non-default value?
            if (LabelPosition.After == LabelPosition)
            {
                // Add the property value.
                attr[nameof(LabelPosition)] = LabelPosition;
            }

            // Return the attributes.
            return attr;
        }

        // *******************************************************************

        /// <inheritdoc/>
        public override int Generate(
            RenderTreeBuilder builder, 
            int index, 
            IHandleEvent eventTarget, 
            Stack<object> path,
            PropertyInfo prop, 
            ILogger<IFormGenerator> logger
            )
        {
            // Validate the parameters before attempting to use them.
            Guard.Instance().ThrowIfNull(builder, nameof(builder))
                .ThrowIfLessThanZero(index, nameof(index))
                .ThrowIfNull(path, nameof(path))
                .ThrowIfNull(logger, nameof(logger));

            try
            {
                // If we get here then we are trying to render an SfCheckBox component
                //   and bind it to the specified bool property.

                // Should never happen, but, pffft, check it anyway.
                if (path.Count < 2)
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "RenderSfCheckBoxAttribute::Generate called with a shallow path!"
                        );

                    // Return the index.
                    return index;
                }

                // Get the model reference.
                var model = path.Peek();

                // Get the property's type.
                var propertyType = prop.PropertyType;

                // Get the property's parent.
                var propParent = path.Skip(1).First();

                // We only render SfCheckBox controls against bools.
                if (propertyType == typeof(bool))
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "Rendering property: '{PropName}' as a SfCheckBox component.",
                        prop.Name
                        );

                    // Get any non-default attribute values (overrides).
                    var attributes = ToAttributes();

                    // Was the Label NOT overridden?
                    if (false == attributes.ContainsKey(nameof(Label)))
                    {
                        // Ensure the Label property value is set.
                        attributes[nameof(Label)] = prop.Name;
                    }

                    // Ensure the Value property value is set.
                    attributes["Checked"] = (bool)prop.GetValue(propParent);

                    // Ensure the ValueChange property is bound, both ways.
                    attributes["ValueChange"] = RuntimeHelpers.TypeCheck<EventCallback<Syncfusion.Blazor.Buttons.ChangeEventArgs<bool>>>(
                        EventCallback.Factory.Create<Syncfusion.Blazor.Buttons.ChangeEventArgs<bool>>(
                            eventTarget,
                            EventCallback.Factory.CreateInferred<Syncfusion.Blazor.Buttons.ChangeEventArgs<bool>>(
                                eventTarget,
                                x => prop.SetValue(propParent, x.Checked),
                                new Syncfusion.Blazor.Buttons.ChangeEventArgs<bool>()
                                {
                                    Checked = (bool)prop.GetValue(propParent)
                                })
                            )
                        );
                                        
                    // Render the property as a SfCheckBox control.
                    index = builder.RenderUIComponent<SfCheckBox<bool>>(
                        index++,
                        attributes: attributes
                        );
                }

                // Otherwise, we don't know this type ...
                else
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "Ignoring property: '{PropName}' on: '{ObjName}' " +
                        "because we only render SfCheckBox components on properties " +
                        "that are of type: bool. That property is of type: '{PropType}'!",
                        prop.Name,
                        propParent.GetType().Name,
                        propertyType.Name
                        );
                }

            }
            catch (Exception ex)
            {
                // Provide better context for the error.
                throw new FormGenerationException(
                    message: "Failed to render an SfCheckBox component! " +
                        "See inner exception(s) for more detail.",
                    innerException: ex
                    );
            }

            return index;
        }

        #endregion
    }
}
