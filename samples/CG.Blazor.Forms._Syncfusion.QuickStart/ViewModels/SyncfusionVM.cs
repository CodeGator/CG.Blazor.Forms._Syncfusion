using System;
using CG.Blazor.Forms.Attributes;

namespace CG.Blazor.Forms._Syncfusion.QuickStart.ViewModels
{
    /// <summary>
    /// This class is a view-model for generating syncfusion forms.
    /// </summary>
    public class SyncfusionVM
    {
        [RenderSfTextBox]
        public string A1 { get; set; } = "A1 value";

        [RenderSfNumericTextBox]
        public int? A2 { get; set; } = 55;

        [RenderSfSlider]
        public int? A3 { get; set; } = 50;

        [RenderSfColorPicker]
        public string A4 { get; set; } = "#00FF00";

        [RenderSfDatePicker]
        public DateTime? A5 { get; set; } = DateTime.Today;

        [RenderSfTimePicker]
        public DateTime? A6 { get; set; } = DateTime.Now;

        [RenderSfCheckBox]
        public bool A7 { get; set; } = true;

        [RenderSfComboBox(Options = "A,B,C,D")]
        public string A8 { get; set; }

        [RenderSfRadioGroup(Options = "A,B,C,D")]
        public string A9 { get; set; } = "B";
    }
}
