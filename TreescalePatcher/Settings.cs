using Mutagen.Bethesda.Synthesis.Settings;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TreescalePatcher
{
    public class Settings
    {
        [SynthesisOrder]
        [SynthesisSettingName("Exclude FormIDs")]
        [SynthesisTooltip("Testing.")]
        public IEnumerable<FormKey>? MyFormKey;
        [SynthesisOrder]
        [SynthesisSettingName("Exclude")]
        [SynthesisTooltip("Test.")]
        //[FormLinkPickerCustomization(typeof(IPlacedObjectGetter))]
        public IFormLinkGetter<IPlacedObjectGetter> Trees = FormLink<IPlacedObjectGetter>.Null;
        //public IFormLinkGetter Trees { get; set; } = FormLinkInformation.Null;
    }
}