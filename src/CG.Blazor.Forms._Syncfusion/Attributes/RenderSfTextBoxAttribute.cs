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
using Syncfusion.Blazor.Inputs;

namespace CG.Blazor.Forms.Attributes
{
    /// <summary>
    /// This class is an attribute that, when applied to a <see cref="string"/> property, 
    /// causes the form generator to render the property as a <see cref="SfTextBox"/> 
    /// component.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This attribute is only valid when placed on a property of type: <see cref="string"/>.
    /// </para>
    /// </remarks>
    /// <example>
    /// Here is an example of decorating a model property to render a  <see cref="SfTextBox"/>:
    /// <code>
    /// using CG.Blazor.Forms.Attributes;
    /// class MyModel
    /// {
    ///     [RenderSfTextBox]
    ///     public string MyProperty { get;set; }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Property)]
    public class RenderSfTextBoxAttribute : SyncfusionAttribute
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This property specifies whether the browser is allowed to automatically 
        /// enter or select a value for the TextBox.
        /// </summary>
        public bool Autocomplete { get; set; }

        /// <summary>
        /// This property specifies the CSS class name that can be appended with 
        /// the root element of the TextBox. One or more custom CSS classes can be 
        /// added to a TextBox.
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// This property specifies a boolean value that indicates whether the 
        /// TextBox allows the user to interact with it.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// This property enable or disable the persisting TextBox state between 
        /// page reloads. If enabled, the Value state will be persisted.
        /// </summary>
        public bool EnablePersistence { get; set; }

        /// <summary>
        /// This property enable or disable rendering component in the right to 
        /// left direction.
        /// </summary>
        public bool EnableRtl { get; set; }

        /// <summary>
        /// This property specifies the floating label behavior of the TextBox that 
        /// the placeholder text floats above the TextBox.
        /// </summary>
        public FloatLabelType FloatLabelType { get; set; }

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
        /// value, and more to the root element. If you configured both property 
        /// and equivalent input attribute, then the component considers the property 
        /// value.
        /// </summary>
        public Dictionary<string, object> InputAttributes { get; set; }

        /// <summary>
        /// This property specifies the global culture and localization of the 
        /// TextBox component.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// This property specifies a boolean value that enables or disables the 
        /// multiline on the TextBox. The TextBox changes from a single line to 
        /// multiline when enabling this multiline mode.
        /// </summary>
        public bool Multiline { get; set; }

        /// <summary>
        /// This property specifies the text that is shown as a hint or placeholder 
        /// until the user focuses or enter a value in TextBox. The property is 
        /// depending on the FloatLabelType property.
        /// </summary>
        public string Placeholder { get; set; }

        /// <summary>
        /// This property specifies the boolean value whether the TextBox allows 
        /// user to change the text.
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// This property specifies a boolean value that indicates whether the
        /// clear button is displayed in TextBox.
        /// </summary>
        public bool ShowClearButton { get; set; }

        /// <summary>
        /// This property specifies the tab order of the TextBox component.
        /// </summary>
        public int? TabIndex { get; set; }

        /// <summary>
        /// This property specifies the behavior of the TextBox such as text, 
        /// password, email, and more.
        /// </summary>
        public InputType InputType { get; set; }

        /// <summary>
        /// This property specifies the width of the TextBox component.
        /// </summary>
        public string Width { get; set; }

        #endregion

        // *******************************************************************
        // Constructors.
        // *******************************************************************

        #region Constructors

        /// <summary>
        /// This constrctor creates a new instance of the <see cref="RenderSfTextBoxAttribute"/>
        /// class.
        /// </summary>
        public RenderSfTextBoxAttribute()
        {
            // Set default values.
            Autocomplete = false;
            CssClass = string.Empty;
            Enabled = true;
            EnableRtl = false;
            FloatLabelType = FloatLabelType.Auto;
            HtmlAttributes = null;
            Id = string.Empty;
            InputAttributes = null;
            Locale = string.Empty;
            Multiline = false;
            Placeholder = string.Empty;
            Readonly = false;
            ShowClearButton = false;
            TabIndex = null;
            InputType = InputType.Text;
            Width = string.Empty;
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
            if (false != Autocomplete)
            {
                // Add the property value.
                attr[nameof(Autocomplete)] = Autocomplete;
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
            if (false != EnablePersistence)
            {
                // Add the property value.
                attr[nameof(EnablePersistence)] = EnablePersistence;
            }

            // This attributes should always be set.
            attr[nameof(FloatLabelType)] = FloatLabelType;

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
            if (false == string.IsNullOrEmpty(Locale))
            {
                // Add the property value.
                attr[nameof(Locale)] = Locale;
            }

            // Does this property have a non-default value?
            if (false != Multiline)
            {
                // Add the property value.
                attr[nameof(Multiline)] = Multiline;
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
            if (false != ShowClearButton)
            {
                // Add the property value.
                attr[nameof(ShowClearButton)] = ShowClearButton;
            }

            // Does this property have a non-default value?
            if (null != TabIndex)
            {
                // Add the property value.
                attr[nameof(TabIndex)] = TabIndex;
            }

            // Does this property have a non-default value?
            if (InputType.Text != InputType)
            {
                // Add the property value.
                attr[nameof(InputType)] = InputType;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Width))
            {
                // Add the property value.
                attr[nameof(Width)] = Width;
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
                // If we get here then we are trying to render an sfTextBox component
                //   and bind it to the specified string property.

                // Should never happen, but, pffft, check it anyway.
                if (path.Count < 2)
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "RendersFTextBoxAttribute::Generate called with a shallow path!"
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

                // We only render SfTextBox controls against strings.
                if (propertyType == typeof(string))
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "Rendering property: '{PropName}' as an SfTextBox component.",
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

                    // Ensure the Value property value is set.
                    attributes["Value"] = prop.GetValue(propParent);

                    // Ensure the ValueChanged property is bound, both ways.
                    attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<string>>(
                        EventCallback.Factory.Create<string>(
                            eventTarget,
                            EventCallback.Factory.CreateInferred<string>(
                                eventTarget,
                                x => prop.SetValue(propParent, x),
                                (string)prop.GetValue(propParent)
                                )
                            )
                        );
                                        
                    // Render the property as a SfTextBox control.
                    index = builder.RenderUIComponent<SfTextBox>(
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
                        "because we only render SfTextBox components on properties " +
                        "that are of type: numeric. That property is of type: '{PropType}'!",
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
                    message: "Failed to render an sfTextBox component! " +
                        "See inner exception(s) for more detail.",
                    innerException: ex
                    );
            }

            return index;
        }

        #endregion
    }
}
