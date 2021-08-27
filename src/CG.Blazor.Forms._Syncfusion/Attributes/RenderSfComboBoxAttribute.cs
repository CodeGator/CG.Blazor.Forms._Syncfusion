using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using CG.Blazor.Forms.Services;
using CG.Validations;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.CompilerServices;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor.DropDowns;
using Syncfusion.Blazor.Inputs;

namespace CG.Blazor.Forms.Attributes
{
    /// <summary>
    /// This class is an attribute that, when applied to a <see cref="string"/> property, 
    /// causes the form generator to render the property as a <see cref="SfComboBox{T1, T2}"/> 
    /// component.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This attribute is only valid when placed on a property of type: <see cref="string"/>.
    /// </para>
    /// </remarks>
    /// <example>
    /// Here is an example of decorating a model property to render a  <see cref="SfComboBox{T1, T2}"/>:
    /// <code>
    /// using CG.Blazor.Forms.Attributes;
    /// class MyModel
    /// {
    ///     [RenderSfComboBox(Options = "A,B,C,D")]
    ///     public string MyProperty { get;set; }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Property)]
    public class RenderSfComboBoxAttribute : SyncfusionAttribute
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This property specifies whether the component allows user defined 
        /// value which does not exist in data source.
        /// </summary>
        public bool AllowCustom { get; set; }

        /// <summary>
        /// This property specifies whether the search bar is visible, or not.
        /// </summary>
        public bool AllowFiltering { get; set; }

        /// <summary>
        /// This property specifies whether suggest a first matched item in 
        /// input when searching. No action happens when no matches found.
        /// </summary>
        public bool Autofill { get; set; }

        /// <summary>
        /// This property specifies the CSS class name that can be appended 
        /// with the root element of the DropDownList. One or more custom CSS 
        /// classes can be added to a DropDownList.
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// This property specifies a boolean value that indicates whether 
        /// the component allows the user to interact with it.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// This property enables or disables persisting component's state 
        /// between page reloads.
        /// </summary>
        public bool EnablePersistence { get; set; }

        /// <summary>
        /// This property enables or disables rendering component in right 
        /// to left direction.
        /// </summary>
        public bool EnableRtl { get; set; }

        /// <summary>
        /// This property specifies whether the virtual scrolling feature 
        /// is enabled for the dropdown list.
        /// </summary>
        public bool EnableVirtualization { get; set; }

        /// <summary>
        /// This property determines on which filter type, the component 
        /// needs to be considered on search action.
        /// </summary>
        public FilterType FilterType { get; set; }

        /// <summary>
        /// This property specifies the floating label behavior of the TextBox that 
        /// the placeholder text floats above the ComboBox.
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
        /// This property sets the index of the selected item in the component.
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// This property contains additional input attributes such as disabled,
        /// value, and more to the root element. If you configured both property 
        /// and equivalent input attribute, then the component considers the property 
        /// value.
        /// </summary>
        public Dictionary<string, object> InputAttributes { get; set; }

        /// <summary>
        /// This property indicates whether to ignore the diacritic 
        /// characters or accents when filtering. True to ignore.
        /// </summary>
        public bool IgnoreAccent { get; set; }

        /// <summary>
        /// This property indicates whether to perform case sensitive 
        /// searches, or not. True to perform case insensitive searches.
        /// </summary>
        public bool IgnoreCase { get; set; }

        /// <summary>
        /// This property specifies the global culture and localization of 
        /// this component.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// This property specifies a comma separated list of options, for the 
        /// component.
        /// </summary>
        public string Options { get; set; }

        /// <summary>
        /// This property specifies the text that is shown as a hint or placeholder 
        /// until the user focuses or enter a value in ComboBox. The property is 
        /// depending on the FloatLabelType property.
        /// </summary>
        public string Placeholder { get; set; }

        /// <summary>
        /// This property specifies the width of the popup list. By default, 
        /// the popup width sets based on the width of the component.
        /// </summary>
        public string PopupWidth { get; set; }

        /// <summary>
        /// This property specifies the boolean value whether the DropDownList 
        /// allows the user to change the value.
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// This property specifies whether to show or hide the clear button.
        /// </summary>
        public bool ShowClearButton { get; set; }

        /// <summary>
        /// This property specifies the tab order of the component.
        /// </summary>
        public int? TabIndex { get; set; }

        /// <summary>
        /// This property specifies the z-index value of the component 
        /// popup element.
        /// </summary>
        public double? ZIndex { get; set; }

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
        /// This constrctor creates a new instance of the <see cref="RenderSfComboBoxAttribute"/>
        /// class.
        /// </summary>
        public RenderSfComboBoxAttribute()
        {
            // Set default values.
            AllowCustom = false;
            AllowFiltering = false;
            Autofill = false;
            CssClass = string.Empty;
            Enabled = true;
            EnablePersistence = false;
            EnableRtl = false;
            EnableVirtualization = false;
            FilterType = FilterType.Contains;
            FloatLabelType = FloatLabelType.Auto;
            HtmlAttributes = null;
            Id = string.Empty;
            Index = null;
            InputAttributes = null;
            IgnoreAccent = false;
            IgnoreCase = false;
            Locale = string.Empty;
            Placeholder = string.Empty;
            PopupWidth = string.Empty;
            Readonly = false;
            ShowClearButton = false;
            TabIndex = null;
            ZIndex = null;
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
            if (false != AllowCustom)
            {
                // Add the property value.
                attr[nameof(AllowCustom)] = AllowCustom;
            }

            // Does this property have a non-default value?
            if (false != AllowFiltering)
            {
                // Add the property value.
                attr[nameof(AllowFiltering)] = AllowFiltering;
            }

            // Does this property have a non-default value?
            if (false != Autofill)
            {
                // Add the property value.
                attr[nameof(Autofill)] = Autofill;
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
            if (false != EnableVirtualization)
            {
                // Add the property value.
                attr[nameof(EnableVirtualization)] = EnableVirtualization;
            }

            // Does this property have a non-default value?
            if (FilterType.Contains != FilterType)
            {
                // Add the property value.
                attr[nameof(FilterType)] = FilterType;
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
            if (null != Index)
            {
                // Add the property value.
                attr[nameof(Index)] = Index;
            }

            // Does this property have a non-default value?
            if (null != InputAttributes)
            {
                // Add the property value.
                attr[nameof(InputAttributes)] = InputAttributes;
            }

            // Does this property have a non-default value?
            if (false != IgnoreAccent)
            {
                // Add the property value.
                attr[nameof(IgnoreAccent)] = IgnoreAccent;
            }

            // Does this property have a non-default value?
            if (false != IgnoreCase)
            {
                // Add the property value.
                attr[nameof(IgnoreCase)] = IgnoreCase;
            }

            // Does this property have a non-default value?
            if (false != IgnoreAccent)
            {
                // Add the property value.
                attr[nameof(IgnoreAccent)] = IgnoreAccent;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Locale))
            {
                // Add the property value.
                attr[nameof(Locale)] = Locale;
            }

            // Note : options deliberately not added to the attributes.

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Placeholder))
            {
                // Add the property value.
                attr[nameof(Placeholder)] = Placeholder;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(PopupWidth))
            {
                // Add the property value.
                attr[nameof(PopupWidth)] = PopupWidth;
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
            if (null != ZIndex)
            {
                // Add the property value.
                attr[nameof(ZIndex)] = ZIndex;
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
                // If we get here then we are trying to render an SfComboBox component
                //   and bind it to the specified string property.

                // Should never happen, but, pffft, check it anyway.
                if (path.Count < 2)
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "RenderSfComboBoxAttribute::Generate called with a shallow path!"
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

                // We only render SfComboBox controls against strings.
                if (propertyType == typeof(string))
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "Rendering property: '{PropName}' as an SfComboBox component.",
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

                    // Set the TValue property value.
                    attributes["TValue"] = "string";

                    // Set the TItem property value.
                    attributes["TItem"] = "string";

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

                    // Split apart the options.
                    var options = Options.Split(',');

                    // Set the data source property.
                    attributes["DataSource"] = options;

                    // Render the property as a SfComboBox control.
                    index = builder.RenderUIComponent<SfComboBox<string, string>>(
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
                        "because we only render SfComboBox components on properties " +
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
                    message: "Failed to render an SfComboBox component! " +
                        "See inner exception(s) for more detail.",
                    innerException: ex
                    );
            }

            return index;
        }

        #endregion
    }
}
