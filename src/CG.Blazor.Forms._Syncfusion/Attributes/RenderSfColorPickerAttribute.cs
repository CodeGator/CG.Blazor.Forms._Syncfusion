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
    /// causes the form generator to render the property as a <see cref="SfColorPicker"/> 
    /// component.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This attribute is only valid when placed on a property of type: <see cref="string"/>.
    /// </para>
    /// </remarks>
    /// <example>
    /// Here is an example of decorating a model property to render a  <see cref="SfColorPicker"/>:
    /// <code>
    /// using CG.Blazor.Forms.Attributes;
    /// class MyModel
    /// {
    ///     [RenderSfColorPicker]
    ///     public string MyProperty { get;set; }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Property)]
    public class RenderSfColorPickerAttribute : SyncfusionAttribute
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This property is used to render the ColorPicker palette with specified 
        /// columns.
        /// </summary>
        public double? Columns { get; set; }

        /// <summary>
        /// This property specifies the CSS class name that can be appended with 
        /// the root element of the TextBox. One or more custom CSS classes can be 
        /// added to a TextBox.
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// This property is used to enable / disable ColorPicker component. If it 
        /// is disabled the ColorPicker popup won’t open.
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// This property  is used to enable / disable the opacity option of 
        /// ColorPicker component.
        /// </summary>
        public bool EnableOpacity { get; set; }

        /// <summary>
        /// This property is used to enable or disable persisting component's 
        /// state between page reloads and it is extended from component class.
        /// </summary>
        public bool EnablePersistence { get; set; }

        /// <summary>
        /// This property enable or disable rendering component in the right to 
        /// left direction.
        /// </summary>
        public bool EnableRtl { get; set; }

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
        /// This property is used to render the ColorPicker component as inline.
        /// </summary>
        public bool Inline { get; set; }
                
        /// <summary>
        /// This property specifies the global culture and localization of the 
        /// TextBox component.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// This property is used to render the ColorPicker with the specified 
        /// mode.
        /// </summary>
        public ColorPickerMode Mode { get; set; }

        /// <summary>
        /// This property is used to show / hide the mode switcher button of 
        /// ColorPicker component.
        /// </summary>
        public bool ModeSwitcher { get; set; }

        /// <summary>
        /// This property is used to enable / disable the no color option of 
        /// ColorPicker component.
        /// </summary>
        public bool NoColor { get; set; }

        /// <summary>
        /// This property is used to load custom colors to palette.
        /// </summary>
        public Dictionary<string, string[]> PresetColors { get; set; }

        /// <summary>
        /// This property specifies the boolean value whether the TextBox allows 
        /// user to change the text.
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// This property is used to show / hide the control buttons (apply / cancel) 
        /// of ColorPicker component.
        /// </summary>
        public bool ShowButtons { get; set; }

        #endregion

        // *******************************************************************
        // Constructors.
        // *******************************************************************

        #region Constructors

        /// <summary>
        /// This constrctor creates a new instance of the <see cref="RenderSfColorPickerAttribute"/>
        /// class.
        /// </summary>
        public RenderSfColorPickerAttribute()
        {
            // Set default values.
            Columns = null;
            CssClass = string.Empty;
            Disabled = false;
            EnableOpacity = false;
            EnablePersistence = false;
            EnableRtl = false;
            HtmlAttributes = null;
            Id = string.Empty;
            Inline = false;
            Locale = string.Empty;
            Mode = ColorPickerMode.Picker;
            ModeSwitcher = false;
            NoColor = false;
            PresetColors = null;
            Readonly = false;
            ShowButtons = false;
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
            if (null != Columns)
            {
                // Add the property value.
                attr[nameof(Columns)] = Columns;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(CssClass))
            {
                // Add the property value.
                attr[nameof(CssClass)] = CssClass;
            }

            // Does this property have a non-default value?
            if (true != Disabled)
            {
                // Add the property value.
                attr[nameof(Disabled)] = Disabled;
            }

            // Does this property have a non-default value?
            if (false != EnableOpacity)
            {
                // Add the property value.
                attr[nameof(EnableOpacity)] = EnableOpacity;
            }

            // Does this property have a non-default value?
            if (false != EnablePersistence)
            {
                // Add the property value.
                attr[nameof(EnablePersistence)] = EnablePersistence;
            }

            // Does this property have a non-default value?
            if (false != EnableRtl)
            {
                // Add the property value.
                attr[nameof(EnableRtl)] = EnableRtl;
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
            if (false != Inline)
            {
                // Add the property value.
                attr[nameof(Inline)] = Inline;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Locale))
            {
                // Add the property value.
                attr[nameof(Locale)] = Locale;
            }

            // Does this property have a non-default value?
            if (ColorPickerMode.Picker != Mode)
            {
                // Add the property value.
                attr[nameof(Mode)] = Mode;
            }

            // Does this property have a non-default value?
            if (false != ModeSwitcher)
            {
                // Add the property value.
                attr[nameof(ModeSwitcher)] = ModeSwitcher;
            }

            // Does this property have a non-default value?
            if (false != Readonly)
            {
                // Add the property value.
                attr[nameof(Readonly)] = Readonly;
            }

            // Does this property have a non-default value?
            if (false != NoColor)
            {
                // Add the property value.
                attr[nameof(NoColor)] = NoColor;
            }

            // Does this property have a non-default value?
            if (null != PresetColors)
            {
                // Add the property value.
                attr[nameof(PresetColors)] = PresetColors;
            }

            // Does this property have a non-default value?
            if (false != Readonly)
            {
                // Add the property value.
                attr[nameof(Readonly)] = Readonly;
            }

            // Does this property have a non-default value?
            if (false != ShowButtons)
            {
                // Add the property value.
                attr[nameof(ShowButtons)] = ShowButtons;
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
                // If we get here then we are trying to render an SfColorPicker component
                //   and bind it to the specified string property.

                // Should never happen, but, pffft, check it anyway.
                if (path.Count < 2)
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "RenderSfColorPickerAttribute::Generate called with a shallow path!"
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

                // We only render SfColorPicker controls against strings.
                if (propertyType == typeof(string))
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "Rendering property: '{PropName}' as an SfColorPicker component.",
                        prop.Name
                        );

                    // Get any non-default attribute values (overrides).
                    var attributes = ToAttributes();

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
                                        
                    // Render the property as a SfColorPicker control.
                    index = builder.RenderUIComponent<SfColorPicker>(
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
                        "because we only render SfColorPicker components on properties " +
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
                    message: "Failed to render an SfColorPicker component! " +
                        "See inner exception(s) for more detail.",
                    innerException: ex
                    );
            }

            return index;
        }

        #endregion
    }
}
