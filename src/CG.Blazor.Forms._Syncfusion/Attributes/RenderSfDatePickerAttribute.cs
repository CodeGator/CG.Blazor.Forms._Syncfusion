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
using Syncfusion.Blazor.Calendars;
using Syncfusion.Blazor.Inputs;

namespace CG.Blazor.Forms.Attributes
{
    /// <summary>
    /// This class is an attribute that, when applied to a <see cref="DateTime?"/> property, 
    /// causes the form generator to render the property as a <see cref="SfDatePicker{T}"/> 
    /// component.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This attribute is only valid when placed on a property of type: <see cref="DateTime?"/>.
    /// </para>
    /// </remarks>
    /// <example>
    /// Here is an example of decorating a model property to render a  <see cref="SfDatePicker{T}"/>:
    /// <code>
    /// using CG.Blazor.Forms.Attributes;
    /// class MyModel
    /// {
    ///     [RenderSfDatePicker]
    ///     public DateTime? MyProperty { get;set; }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Property)]
    public class RenderSfDatePickerAttribute : SyncfusionAttribute
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This property specifies a boolean value whether the DatePicker allows 
        /// user to change the value via typing. When set as false, the DatePicker 
        /// allows user to change the value via picker only.
        /// </summary>
        public bool AllowEdit { get; set; }

        /// <summary>
        /// This property specifies the CSS class name that can be appended with 
        /// the root element of the TextBox. One or more custom CSS classes can be 
        /// added to a TextBox.
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// This property specifies a boolean value that indicates whether the 
        /// DatePicker allows the user to interact with it.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// This property enable or disable rendering component in the right to 
        /// left direction.
        /// </summary>
        public bool EnableRtl { get; set; }

        /// <summary>
        /// This property specifies the floating label behavior of the TextBox that 
        /// the placeholder text floats above the TextBox based on the following values.
        /// <list type="bullet">
        /// <listheader>Possible values are:</listheader>
        /// <item>NeverNever floats the label in the TextBox when the placeholder 
        /// is available.</item>
        /// <item>AlwaysThe floating label always floats above the TextBox.</item>
        /// <item>AutoThe floating label floats above the TextBox after focusing 
        /// it or when enters the value in it.</item>
        /// list>
        /// </summary>
        public FloatLabelType FloatLabelType { get; set; }

        /// <summary>
        /// This property specifies the format of the value that to be displayed in 
        /// component. By default, the format is based on the culture.You can set 
        /// the format to "format:'dd/MM/yyyy hh:mm'".
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// This property contains additional html attributes such as styles, class, 
        /// and more to the root element. If you configured both property and equivalent 
        /// html attributes, then the component considers the property value.
        /// </summary>
        public IDictionary<string, object> HtmlAttributes { get; set; }

        /// <summary>
        /// This property specifies the id of the TextBox component.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// This property contains additional input attributes such as disabled, 
        /// value, and more to the root element. If you configured both the 
        /// property and equivalent input attribute, then the component considers 
        /// the property value.
        /// </summary>
        public Dictionary<string, object> InputAttributes { get; set; }

        /// <summary>
        /// This property specifies the text that is shown as a hint or placeholder 
        /// until the user focuses or enter a value in DatePicker. The property is 
        /// depending on the FloatLabelType property.
        /// </summary>
        public string Placeholder { get; set; }

        /// <summary>
        /// This property specifies the boolean value whether the DatePicker allows 
        /// the user to change the text.
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// This property specifies the component to act as strict. So that, it 
        /// allows to enter only a valid date value within a specified range or 
        /// else it will resets to previous value. By default, StrictMode is in 
        /// false. It allows invalid or out-of-range date value with highlighted 
        /// error class.
        /// </summary>
        public bool StrictMode { get; set; }

        /// <summary>
        /// This property specifies the tab order of the DatePicker component.
        /// </summary>
        public int TabIndex { get; set; }

        /// <summary>
        /// This property specifies the width of the DatePicker component.
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// This property specifies the z-index value of the DatePicker popup 
        /// element.
        /// </summary>
        public int ZIndex { get; set; }

        #endregion

        // *******************************************************************
        // Constructors.
        // *******************************************************************

        #region Constructors

        /// <summary>
        /// This constrctor creates a new instance of the <see cref="RenderSfDatePickerAttribute"/>
        /// class.
        /// </summary>
        public RenderSfDatePickerAttribute()
        {
            // Set default values.
            AllowEdit = false;
            CssClass = string.Empty;
            Enabled = true;
            EnableRtl = false;
            FloatLabelType = FloatLabelType.Auto;
            Format = string.Empty;
            HtmlAttributes = null;
            Id = string.Empty;
            InputAttributes = null;
            Placeholder = string.Empty;
            Readonly = false;
            StrictMode = false;
            TabIndex = -1;
            Width = string.Empty;
            ZIndex = 1;
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
            if (false != AllowEdit)
            {
                // Add the property value.
                attr[nameof(AllowEdit)] = AllowEdit;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(CssClass))
            {
                // Add the property value.
                attr[nameof(CssClass)] = CssClass;
            }

            // Does this property have a non-default value?
            if (true != Enabled)
            {
                // Add the property value.
                attr[nameof(Enabled)] = Enabled;
            }

            // Does this property have a non-default value?
            if (false != EnableRtl)
            {
                // Add the property value.
                attr[nameof(EnableRtl)] = EnableRtl;
            }

            // Does this property have a non-default value?
            if (FloatLabelType.Auto != FloatLabelType)
            {
                // Add the property value.
                attr[nameof(FloatLabelType)] = FloatLabelType;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Format))
            {
                // Add the property value.
                attr[nameof(Format)] = Format;
            }

            // Does this property have a non-default value?
            if (null != HtmlAttributes)
            {
                // Add the property value.
                attr[nameof(HtmlAttributes)] = HtmlAttributes;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Id))
            {
                // Add the property value.
                attr[nameof(Id)] = Id;
            }

            // Does this property have a non-default value?
            if (null != InputAttributes)
            {
                // Add the property value.
                attr[nameof(InputAttributes)] = InputAttributes;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Placeholder))
            {
                // Add the property value.
                attr[nameof(Placeholder)] = Placeholder;
            }

            // Does this property have a non-default value?
            if (false != Readonly)
            {
                // Add the property value.
                attr[nameof(Readonly)] = Readonly;
            }

            // Does this property have a non-default value?
            if (false != StrictMode)
            {
                // Add the property value.
                attr[nameof(StrictMode)] = StrictMode;
            }

            // Does this property have a non-default value?
            if (-1 != TabIndex)
            {
                // Add the property value.
                attr[nameof(TabIndex)] = TabIndex;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Width))
            {
                // Add the property value.
                attr[nameof(Width)] = Width;
            }

            // Does this property have a non-default value?
            if (1 != ZIndex)
            {
                // Add the property value.
                attr[nameof(ZIndex)] = ZIndex;
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
                // If we get here then we are trying to render an SfDatePicker component
                //   and bind it to the specified string property.

                // Should never happen, but, pffft, check it anyway.
                if (path.Count < 2)
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "RenderSfDatePickerAttribute::Generate called with a shallow path!"
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

                // Should we bind to a DateTime?
                if (propertyType == typeof(Nullable<DateTime>))
                {
                    index = BindToDateTime(
                        builder,
                        index,
                        eventTarget,
                        prop,
                        logger,
                        propertyType,
                        model,
                        propParent
                        );
                }

                // Otherwise, we don't know this type ...
                else
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "Ignoring property: '{PropName}' on: '{ObjName}' " +
                        "because we only render SfDatePicker components on properties " +
                        "that are of type: DateTime?. That property is of type: '{PropType}'!",
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
                    message: "Failed to render an SfDatePicker component! " +
                        "See inner exception(s) for more detail.",
                    innerException: ex
                    );
            }

            return index;
        }

        #endregion

        // *******************************************************************
        // Private methods.
        // *******************************************************************

        #region Private methods

        /// <summary>
        /// This method generates a SfDatePicker control that is bound to a 
        /// <see cref="DateTime"/> property.
        /// </summary>
        /// <param name="builder">The builder to use for the operation.</param>
        /// <param name="index">The index to use for the operation.</param>
        /// <param name="eventTarget">The event target to use for the 
        /// operation.</param>
        /// <param name="prop">The reflection information for the property.</param>
        /// <param name="logger">The logger to use for the operation.</param>
        /// <param name="propertyType">The type of property to use for the 
        /// operation.</param>
        /// <param name="model">The model to use for the operation.</param>
        /// <param name="propParent">The property parent to use for the 
        /// operation.</param>
        /// <returns>The index after rendering is complete.</returns>
        private int BindToDateTime(
            RenderTreeBuilder builder,
            int index,
            IHandleEvent eventTarget,
            PropertyInfo prop,
            ILogger<IFormGenerator> logger,
            Type propertyType,
            object model,
            object propParent
            )
        {
            // Let the world know what we're doing.
            logger.LogDebug(
                "Rendering property: '{PropName}' as a SfDatePicker.",
                prop.Name
                );

            // Get any non-default attribute values (overrides).
            var attributes = ToAttributes();

            // Was the Placeholder NOT overridden?
            if (false == attributes.ContainsKey(nameof(Placeholder)))
            {
                // Ensure the Placeholder property value is set.
                attributes[nameof(Placeholder)] = prop.Name;
            }

            // Is the type NOT nullable?
            if (propertyType == typeof(DateTime?))
            {
                // Set the type.
                attributes["TValue"] = "DateTime?";

                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (DateTime?)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<DateTime?>>(
                    EventCallback.Factory.Create<DateTime?>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<DateTime?>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            (DateTime?)prop.GetValue(propParent)
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfDatePicker<DateTime?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        #endregion
    }
}
