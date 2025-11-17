using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Synthesis.Settings;

namespace TreescalePatcher
{
    public class Settings
    {
        [SynthesisOrder]
        [SynthesisSettingName("Ignore FormIDs")]
        [SynthesisTooltip("Provided FormIDs will be ignored. Input must have the format \"FFFFFF:Skyrim.esm\" and omit the leading \"0x\" master index.")]
        public IEnumerable<FormKey>? Ignored;
    }
}