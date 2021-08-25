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
using Syncfusion.Blazor.Buttons;

namespace CG.Blazor.Forms.Attributes
{
    /// <summary>
    /// This class is an attribute that, when applied to a <see cref="string"/> property, 
    /// causes the form generator to render the property as a collection of <see cref="SfRadioButton{T}"/> 
    /// components.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This attribute is only valid when placed on a property of type: <see cref="string"/>.
    /// </para>
    /// </remarks>
    /// <example>
    /// Here is an example of decorating a model property to render a collection of
    /// <see cref="SfRadioButton{T}"/> components:
    /// <code>
    /// using CG.Blazor.Forms.Attributes;
    /// class MyModel
    /// {
    ///     [RenderSfRadioGroup(Options = "A,B,C,D")]
    ///     public string MyProperty { get;set; }
    /// }
    /// </code>
    /// </example>
    [AttributeUsage(AttributeTargets.Property)]
    public class RenderSfRadioGroupAttribute : SyncfusionAttribute
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
        /// This property specifies the caption for the RadioButton, that
        /// describes the purpose of the group.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// This property positions label before/after the radio buttons.
        /// <list type="bullet">
        /// <listheader>Possible values are:</listheader>
        /// <item>Before: The label is positioned to left of the RadioButton.</item>
        /// <item>After: The label is positioned to right of the RadioButton.</item>
        /// </list>
        /// </summary>
        public LabelPosition LabelPosition { get; set; }

        /// <summary>
        /// This property contains a comma separated list of options for the group.
        /// </summary>
        public string Options { get; set; }

        #endregion

        // *******************************************************************
        // Constructors.
        // *******************************************************************

        #region Constructors

        /// <summary>
        /// This constrctor creates a new instance of the <see cref="RenderSfRadioGroupAttribute"/>
        /// class.
        /// </summary>
        public RenderSfRadioGroupAttribute()
        {
            // Set default values.
            CssClass = string.Empty;
            EnablePersistence = false;
            EnableRtl = false;
            Label = string.Empty;
            LabelPosition = LabelPosition.After;
            Options = string.Empty;
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

            // Note : label deliberately not added to the attributes.

            // Does this property have a non-default value?
            if (LabelPosition.After != LabelPosition)
            {
                // Add the property value.
                attr[nameof(LabelPosition)] = LabelPosition;
            }

            // Note : options deliberately not added to the attributes.

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
                // If we get here then we are trying to render a group of SfRadioButton
                // components and bind them to the specified string property.

                // Should never happen, but, pffft, check it anyway.
                if (path.Count < 2)
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "RenderSfRadioGroupAttribute::Generate called with a shallow path!"
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

                // We only render radio groups against strings.
                if (propertyType == typeof(string))
                {
                    // Let the world know what we're doing.
                    logger.LogDebug(
                        "Rendering property: '{PropName}' as a collection of SfRadioButton components.",
                        prop.Name
                        );

                    // Get any non-default attribute values (overrides).
                    var attributes = ToAttributes();

                    // Was the Label NOT overridden?
                    if (false == attributes.ContainsKey(nameof(Label)))
                    {
                        // Ensure the Placeholder property value is set.
                        attributes[nameof(Label)] = prop.Name;
                    }

                    // Ensure the Checked property is bound, both ways.
                    attributes["CheckedChanged"] = RuntimeHelpers.TypeCheck<EventCallback<string>>(
                        EventCallback.Factory.Create<string>(
                            eventTarget,
                            EventCallback.Factory.CreateInferred<string>(
                                eventTarget,
                                x => prop.SetValue(propParent, x),
                                (string)prop.GetValue(propParent)
                                )
                            )
                        );

                    // Create the label.
                    var label = string.IsNullOrEmpty(Label) ? prop.Name : Label;

                    // Split the options.
                    var options = Options.Split(',');

                    // Ensure the Name property value is set.
                    attributes["name"] = prop.Name;

                    // Get the current model value.
                    var value = (string)prop.GetValue(propParent);

                    // Render the outermost fieldset.
                    index = builder.RenderUIElement(
                        index,
                        "fieldset",
                        contentDelegate: fieldSetBuilder =>
                        {
                            // Render the legend.
                            index = fieldSetBuilder.RenderUIElement(
                                index,
                                "legend",
                                contentDelegate: legendBuilder =>
                                    legendBuilder.AddContent(index++, label)
                                );

                            // Render the div.
                            index = fieldSetBuilder.RenderUIElement(
                                    index,
                                    "div",
                                    contentDelegate: divBuilder =>
                                    {
                                        // Loop through the options.
                                        foreach (var option in options)
                                        {
                                            // Set the value for the option.
                                            attributes["Value"] = option;

                                            // Set the label for the option.
                                            attributes["Label"] = option;

                                            // Set the check for the option.
                                            attributes["Checked"] = value;

                                            // Render the radio button.
                                            index = divBuilder.RenderUIComponent<SfRadioButton<string>>(
                                                index,
                                                attributes: attributes
                                                );
                                        }
                                    });
                        });
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
