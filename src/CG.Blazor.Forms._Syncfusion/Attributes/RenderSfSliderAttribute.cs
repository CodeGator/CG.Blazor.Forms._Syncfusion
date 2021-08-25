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
    /// causes the form generator to render the property as a <see cref="SfSlider{T}"/> 
    /// component.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This attribute is only valid when placed on a property of type: numeric,
    /// which is byte, int, long, float, double, or decimal.
    /// </para>
    /// </remarks>
    /// <example>
    /// Here is an example of decorating a model property to render a  <see cref="SfSlider{T}"/>:
    /// <code>
    /// using CG.Blazor.Forms.Attributes;
    /// class MyModel
    /// {
    ///     [RenderSfSlider]
    ///     public int MyProperty { get;set; }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Property)]
    public class RenderSfSliderAttribute : SyncfusionAttribute
    {
        // *******************************************************************
        // Properties.
        // *******************************************************************

        #region Properties

        /// <summary>
        /// This property specifies the color to the slider based on given value.
        /// </summary>
        public List<ColorRangeDataModel> ColorRange { get; set; }

        /// <summary>
        /// This property specifies the CSS class name that can be appended with 
        /// the root element of the TextBox. One or more custom CSS classes can be 
        /// added to a TextBox.
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// This property specifies an array of slider values in number or string 
        /// type. The min and max step values are not considered.
        /// </summary>
        public string[] CustomValues { get; set; }

        /// <summary>
        /// This property enables/Disables the animation for slider movement.
        /// </summary>
        public bool EnableAnimation { get; set; }

        /// <summary>
        /// This property specifies a boolean value that indicates whether the 
        /// TextBox allows the user to interact with it.
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// This property defines whether to allow the cross-scripting site or not.
        /// </summary>
        public bool EnableHtmlSanitizer { get; set; }

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
        /// This property specifies whether the value need to be updated at the 
        /// time of dragging slider handle.
        /// </summary>
        public bool IsImmediateValue { get; set; }

        /// <summary>
        /// This property specified the limit within which the slider to be moved.
        /// </summary>
        public SliderLimits Limits { get; set; }

        /// <summary>
        /// This property overrides the global culture and localization value for 
        /// this component. Default global culture is 'en-US'.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// This property specifies a maximum value that is allowed a user can 
        /// enter.
        /// </summary>
        public double? Max { get; set; }

        /// <summary>
        /// This property specifies a minimum value that is allowed a user can 
        /// enter.
        /// </summary>
        public double? Min { get; set; }

        /// <summary>
        /// This property specifies whether to render the slider in vertical 
        /// or horizontal orientation.
        /// </summary>
        public SliderOrientation Orientation { get; set; }

        /// <summary>
        /// This property specifies whether the render the slider in read-only 
        /// mode to restrict any user interaction. The slider rendered with 
        /// user defined values and can’t be interacted with user actions.
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// This property specifies whether to show or hide the increase/decrease 
        /// buttons of Slider to change the slider value.
        /// </summary>
        public bool ShowButtons { get; set; }

        /// <summary>
        /// This property specifies the step value for each value change when 
        /// the increase / decrease button is clicked or on arrow keys press 
        /// or on dragging the thumb.
        /// </summary>
        public double? Step { get; set; }

        /// <summary>
        /// This property is used to render the slider ticks options such as 
        /// placement and step values.
        /// </summary>
        public SliderTicks Ticks { get; set; }

        /// <summary>
        /// This property specifies the visibility, position of the tooltip 
        /// over the slider element.
        /// </summary>
        public SliderTooltip Tooltip { get; set; }

        /// <summary>
        /// This property specifies the tab order of the TextBox component.
        /// </summary>
        public int TabIndex { get; set; }

        /// <summary>
        /// This property defines the type of the Slider. The available options 
        /// are: Default - Allows to a single value in the Slider. MinRange - 
        /// Allows to select a single value in the Slider. It display’s a 
        /// shadow from the start to the current value. Range - Allows to 
        /// select a range of values in the Slider. It displays shadow 
        /// in-between the selection range.
        /// </summary>
        public SliderType Type { get; set; }

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
        /// This constrctor creates a new instance of the <see cref="RenderSfSliderAttribute"/>
        /// class.
        /// </summary>
        public RenderSfSliderAttribute()
        {
            // Set default values.
            ColorRange = null;
            CssClass = string.Empty;
            CustomValues = null;
            EnableAnimation = true;
            Enabled = true;
            EnableHtmlSanitizer = false;
            EnablePersistence = false;
            EnableRtl = false;
            HtmlAttributes = null;
            Id = string.Empty;
            IsImmediateValue = true;
            Limits = null;
            Locale = string.Empty;
            Max = null;
            Min = null;
            Orientation = SliderOrientation.Horizontal;
            Readonly = false;
            ShowButtons = true;
            Step = null;
            Ticks = null;
            Tooltip = null;
            TabIndex = -1;
            Type = SliderType.Default;
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
            if (null != ColorRange)
            {
                // Add the property value.
                attr[nameof(ColorRange)] = ColorRange;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(CssClass))
            {
                // Add the property value.
                attr[nameof(CssClass)] = CssClass;
            }

            // Does this property have a non-default value?
            if (null != CustomValues)
            {
                // Add the property value.
                attr[nameof(CustomValues)] = CustomValues;
            }

            // Does this property have a non-default value?
            if (true != EnableAnimation)
            {
                // Add the property value.
                attr[nameof(EnableAnimation)] = EnableAnimation;
            }

            // Does this property have a non-default value?
            if (true != Enabled)
            {
                // Add the property value.
                attr[nameof(Enabled)] = Enabled;
            }

            // Does this property have a non-default value?
            if (false != EnableHtmlSanitizer)
            {
                // Add the property value.
                attr[nameof(EnableHtmlSanitizer)] = EnableHtmlSanitizer;
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
            if (true != IsImmediateValue)
            {
                // Add the property value.
                attr[nameof(IsImmediateValue)] = IsImmediateValue;
            }

            // Does this property have a non-default value?
            if (null != Limits)
            {
                // Add the property value.
                attr[nameof(Limits)] = Limits;
            }

            // Does this property have a non-default value?
            if (false == string.IsNullOrEmpty(Locale))
            {
                // Add the property value.
                attr[nameof(Locale)] = Locale;
            }

            // Does this property have a non-default value?
            if (null != Max)
            {
                // Add the property value.
                attr[nameof(Max)] = Max;
            }

            // Does this property have a non-default value?
            if (null != Min)
            {
                // Add the property value.
                attr[nameof(Min)] = Min;
            }

            // Does this property have a non-default value?
            if (SliderOrientation.Horizontal != Orientation)
            {
                // Add the property value.
                attr[nameof(Orientation)] = Orientation;
            }

            // Does this property have a non-default value?
            if (false != Readonly)
            {
                // Add the property value.
                attr[nameof(Readonly)] = Readonly;
            }

            // Does this property have a non-default value?
            if (true != ShowButtons)
            {
                // Add the property value.
                attr[nameof(ShowButtons)] = ShowButtons;
            }
                        
            // Does this property have a non-default value?
            if (null != Step)
            {
                // Add the property value.
                attr[nameof(Step)] = Step;
            }

            // Does this property have a non-default value?
            if (null != Ticks)
            {
                // Add the property value.
                attr[nameof(Ticks)] = Ticks;
            }

            // Does this property have a non-default value?
            if (null != Tooltip)
            {
                // Add the property value.
                attr[nameof(Tooltip)] = Tooltip;
            }

            // Does this property have a non-default value?
            if (-1 != TabIndex)
            {
                // Add the property value.
                attr[nameof(TabIndex)] = TabIndex;
            }

            // Does this property have a non-default value?
            if (SliderType.Default != Type)
            {
                // Add the property value.
                attr[nameof(Type)] = Type;
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
                // If we get here then we are trying to render an SfSlider component
                //   and bind it to the specified numeric property.

                // Should never happen, but, pffft, check it anyway.
                if (path.Count < 2)
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "RenderSfSliderAttribute::Generate called with a shallow path!"
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
                        "because we only render SfSlider components on properties " +
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
                    message: "Failed to render an SfSlider component! " +
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
        /// This method generates a SfSlider control that is bound to 
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
                "Rendering property: '{PropName}' as a SfSlider.",
                prop.Name
                );

            // Get any non-default attribute values (overrides).
            var attributes = ToAttributes();

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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<byte>>(
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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<byte?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfSlider control that is bound to 
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
                "Rendering property: '{PropName}' as a SfSlider.",
                prop.Name
                );

            // Get any non-default attribute values (overrides).
            var attributes = ToAttributes();

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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<int>>(
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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<int?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfSlider control that is bound to 
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
                "Rendering property: '{PropName}' as a SfSlider.",
                prop.Name
                );

            // Get any non-default attribute values (overrides).
            var attributes = ToAttributes();

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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<long>>(
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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<long?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfSlider control that is bound to 
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
                "Rendering property: '{PropName}' as a SfSlider.",
                prop.Name
                );

            // Get any non-default attribute values (overrides).
            var attributes = ToAttributes();

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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<float>>(
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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<float?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfSlider control that is bound to 
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
                "Rendering property: '{PropName}' as a SfSlider.",
                prop.Name
                );

            // Get any non-default attribute values (overrides).
            var attributes = ToAttributes();

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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<double>>(
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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<double?>>(
                    index++,
                    attributes: attributes
                    );
            }

            // Return the index.
            return index;
        }

        // *******************************************************************

        /// <summary>
        /// This method generates a SfSlider control that is bound to 
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
                "Rendering property: '{PropName}' as a SfSlider.",
                prop.Name
                );

            // Get any non-default attribute values (overrides).
            var attributes = ToAttributes();

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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<decimal>>(
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

                // Render as a SfSlider control.
                index = builder.RenderUIComponent<SfSlider<decimal?>>(
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
