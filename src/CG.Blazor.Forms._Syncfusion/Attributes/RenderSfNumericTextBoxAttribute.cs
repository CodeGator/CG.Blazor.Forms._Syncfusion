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
    /// This class is an attribute that, when applied to a numeric property, 
    /// causes the form generator to render the property as a <see cref="SfNumericTextBox{T}"/> 
    /// component.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This attribute is only valid when placed on a property of type: numeric,
    /// which is byte, int, long, float, double, or decimal.
    /// </para>
    /// </remarks>
    /// <example>
    /// Here is an example of decorating a model property to render a  <see cref="SfNumericTextBox{T}"/>:
    /// <code>
    /// using CG.Blazor.Forms.Attributes;
    /// class MyModel
    /// {
    ///     [RenderSfNumericTextBox]
    ///     public byte MyProperty { get;set; }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Property)]
    public class RenderSfNumericTextBoxAttribute : SyncfusionAttribute
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This property specifies the CSS class name that can be appended with 
        /// the root element of the TextBox. One or more custom CSS classes can be 
        /// added to a TextBox.
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// This property specifies the currency code to use in currency formatting. 
        /// Possible values are the ISO 4217 currency codes, such as 'USD' for the 
        /// US dollar and 'EUR' for the euro.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// This property specifies the number precision applied to the textbox value 
        /// when the NumericTextBox is focused.
        /// </summary>
        public Nullable<int> Decimals { get; set; }

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
        /// This property specifies the number format that indicates the display 
        /// format for the value of the NumericTextBox.
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
        /// This property specifies a maximum value that is allowed a user can 
        /// enter.
        /// </summary>
        public string Max { get; set; }

        /// <summary>
        /// This property specifies a minimum value that is allowed a user can 
        /// enter.
        /// </summary>
        public string Min { get; set; }

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
        /// This property specifies whether the up and down spin buttons will be 
        /// displayed in NumericTextBox.
        /// </summary>
        public bool ShowSpinButton { get; set; }

        /// <summary>
        /// This property specifies the incremental or decremental step size 
        /// for the NumericTextBox.
        /// </summary>
        public string Step { get; set; }

        /// <summary>
        /// This property specifies a value that indicates whether the 
        /// NumericTextBox component allows the value for the specified range.
        /// <list type="bullet">
        /// <item>True - the input value will be restricted between the min and 
        /// max range.The typed value gets modified to fit the range on a focused 
        /// out state.</item>
        /// <item>False - it allows any value even out of range value, at that time 
        /// of wrong value entered, the error class will be added to the component 
        /// to highlight the error.</item>
        /// </list>
        /// </summary>
        public bool StrictMode { get; set; }

        /// <summary>
        /// This property specifies the tab order of the TextBox component.
        /// </summary>
        public int TabIndex { get; set; }

        /// <summary>
        /// This property specifies the behavior of the TextBox such as text, 
        /// password, email, and more.
        /// </summary>
        public InputType InputType { get; set; }

        /// <summary>
        /// This property specifies whether the length of the decimal should 
        /// be restricted during typing.
        /// </summary>
        public bool ValidateDecimalOnType { get; set; }

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
        /// This constrctor creates a new instance of the <see cref="RenderSfNumericTextBoxAttribute"/>
        /// class.
        /// </summary>
        public RenderSfNumericTextBoxAttribute()
        {
            // Set default values.
            CssClass = string.Empty;
            Currency = string.Empty;
            Decimals = null;
            Enabled = true;
            EnablePersistence = false;
            EnableRtl = false;
            FloatLabelType = FloatLabelType.Auto;
            Format = string.Empty;
            HtmlAttributes = null;
            Id = string.Empty;
            InputAttributes = null;
            Locale = string.Empty;
            Max = string.Empty;
            Min = string.Empty;
            Placeholder = string.Empty;
            Readonly = false;
            ShowClearButton = false;
            ShowSpinButton = false;
            Step = string.Empty;
            StrictMode = false;
            TabIndex = -1;
            InputType = InputType.Text;
            ValidateDecimalOnType = false;
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
            if (false == string.IsNullOrEmpty(CssClass))
            {
                // Add the property value.
                attr[nameof(CssClass)] = CssClass;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Currency))
            {
                // Add the property value.
                attr[nameof(Currency)] = Currency;
            }

            // Does this property have a non-default value?
            if (null != Decimals)
            {
                // Add the property value.
                attr[nameof(Decimals)] = Decimals;
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

            // This attributes should always be set.
            attr[nameof(FloatLabelType)] = FloatLabelType;

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
            if (false == string.IsNullOrEmpty(Locale))
            {
                // Add the property value.
                attr[nameof(Locale)] = Locale;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Max))
            {
                // Add the property value.
                attr[nameof(Max)] = Max;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Min))
            {
                // Add the property value.
                attr[nameof(Min)] = Min;
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
            if (false != ShowSpinButton)
            {
                // Add the property value.
                attr[nameof(ShowSpinButton)] = ShowSpinButton;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Step))
            {
                // Add the property value.
                attr[nameof(Step)] = Step;
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
            if (InputType.Text != InputType)
            {
                // Add the property value.
                attr[nameof(InputType)] = InputType;
            }

            // Does this property have a non-default value?
            if (false != ValidateDecimalOnType)
            {
                // Add the property value.
                attr[nameof(ValidateDecimalOnType)] = ValidateDecimalOnType;
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
                // If we get here then we are trying to render an sfNumericTextBox component
                //   and bind it to the specified numeric property.

                // Should never happen, but, pffft, check it anyway.
                if (path.Count < 2)
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "RenderSfNumericTextBoxAttribute::Generate called with a shallow path!"
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

                // Should we bind to a byte?
                if (propertyType == typeof(byte) ||
                    propertyType == typeof(Nullable<byte>))
                {
                    index = BindToByte(
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

                // Should we bind to an int?
                else if (propertyType == typeof(int) ||
                    propertyType == typeof(Nullable<int>))
                {
                    index = BindToInt(
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

                    // Should we bind to a long?
                else if (propertyType == typeof(long) ||
                    propertyType == typeof(Nullable<long>))
                {
                    index = BindToLong(
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

                // Should we bind to a float?
                else if (propertyType == typeof(float) ||
                    propertyType == typeof(Nullable<float>))
                {
                    index = BindToFloat(
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

                // Should we bind to a double?
                else if (propertyType == typeof(double) ||
                    propertyType == typeof(Nullable<double>))
                {
                    index = BindToDouble(
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

                // Should we bind to a decimal?
                else if (propertyType == typeof(decimal) ||
                    propertyType == typeof(Nullable<decimal>))
                {
                    index = BindToDecimal(
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
                        "because we only render SfNumericTextBox components on properties " +
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
                    message: "Failed to render an SfNumericTextBox component! " +
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
        /// This method generates a SfNumericTextBox control that is bound to 
        /// a byte property.
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
        private int BindToByte(
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
                "Rendering property: '{PropName}' as a SfNumericTextBox.",
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
            if (propertyType == typeof(byte))
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (byte)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<byte>>(
                    EventCallback.Factory.Create<byte>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<byte>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (byte)prop.GetValue(propParent) : (byte)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<byte>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Otherwise, the property IS nullable.
            else
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (byte?)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<byte?>>(
                    EventCallback.Factory.Create<byte?>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<byte?>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (byte?)prop.GetValue(propParent) : (byte?)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<byte?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfNumericTextBox control that is bound to 
        /// an int property.
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
        private int BindToInt(
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
                "Rendering property: '{PropName}' as a SfNumericTextBox.",
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

            // Is the NOT property nullable?
            if (propertyType == typeof(int))
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (int)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<int>>(
                    EventCallback.Factory.Create<int>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<int>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (int)prop.GetValue(propParent) : (int)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<int>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Otherwise, the property IS nullable.
            else
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (int?)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<int?>>(
                    EventCallback.Factory.Create<int?>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<int?>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (int?)prop.GetValue(propParent) : (int?)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<int?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfNumericTextBox control that is bound to 
        /// a long property.
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
        private int BindToLong(
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
                "Rendering property: '{PropName}' as a SfNumericTextBox.",
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

            // Is the NOT property nullable?
            if (propertyType == typeof(long))
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (long)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<long>>(
                    EventCallback.Factory.Create<long>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<long>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (long)prop.GetValue(propParent) : (long)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<long>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Otherwise, the property IS nullable.
            else
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (long?)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<long?>>(
                    EventCallback.Factory.Create<long?>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<long?>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (long?)prop.GetValue(propParent) : (long?)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<long?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfNumericTextBox control that is bound to 
        /// a float property.
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
        private int BindToFloat(
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
                "Rendering property: '{PropName}' as a SfNumericTextBox.",
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

            // Is the NOT property nullable?
            if (propertyType == typeof(float))
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (float)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<float>>(
                    EventCallback.Factory.Create<float>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<float>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (float)prop.GetValue(propParent) : (float)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<float>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Otherwise, the property IS nullable.
            else
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (float?)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<float?>>(
                    EventCallback.Factory.Create<float?>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<float?>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (float?)prop.GetValue(propParent) : (float?)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<float?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfNumericTextBox control that is bound to 
        /// a double property.
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
        private int BindToDouble(
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
                "Rendering property: '{PropName}' as a SfNumericTextBox.",
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

            // Is the NOT property nullable?
            if (propertyType == typeof(double))
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (double)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<double>>(
                    EventCallback.Factory.Create<double>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<double>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (double)prop.GetValue(propParent) : (double)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<double>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Otherwise, the property IS nullable.
            else
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (double?)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<double?>>(
                    EventCallback.Factory.Create<double?>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<double?>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (double?)prop.GetValue(propParent) : (double?)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<double?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfNumericTextBox control that is bound to 
        /// a decimal property.
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
        private int BindToDecimal(
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
                "Rendering property: '{PropName}' as a SfNumericTextBox.",
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

            // Is the NOT property nullable?
            if (propertyType == typeof(decimal))
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (decimal)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<decimal>>(
                    EventCallback.Factory.Create<decimal>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<decimal>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (decimal)prop.GetValue(propParent) : (decimal)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<decimal>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Otherwise, the property IS nullable.
            else
            {
                // Is there a value?
                if (null != model)
                {
                    // Ensure the Value property value is set.
                    attributes["Value"] = (decimal?)prop.GetValue(propParent);
                }

                // Ensure the Value property is bound, both ways.
                attributes["ValueChanged"] = RuntimeHelpers.TypeCheck<EventCallback<decimal?>>(
                    EventCallback.Factory.Create<decimal?>(
                        eventTarget,
                        EventCallback.Factory.CreateInferred<decimal?>(
                            eventTarget,
                            x => prop.SetValue(propParent, x),
                            null != model ? (decimal?)prop.GetValue(propParent) : (decimal?)0
                            )
                        )
                    );

                // Render as a SfNumericTextBox control.
                index = builder.RenderUIComponent<SfNumericTextBox<decimal?>>(
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
