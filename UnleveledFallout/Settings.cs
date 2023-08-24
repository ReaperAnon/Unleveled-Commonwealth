using Mutagen.Bethesda.Fallout4;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnleveledFallout
{
    public class UnleveledFalloutConfig
    {
        [SettingName("Health Per Endurance Point")]
        [Tooltip("The amount of health a single point of Endurance gives.")]
        public float fAVDHealthStartEndMult { get; set; } = 3.181818f;

        [SettingName("Endurance Offset")]
        [Tooltip("Extra health gained for every level.")]
        public float fHealthEnduranceOffset { get; set; } = 0;

        [SettingName("Endurance to Health Per Level Multiplier")]
        [Tooltip("The multiplier for how much extra Health the Endurance stat results in per level. A value of 1 means every point of Endurance is 1 extra health per level.")]
        public float fHealthEnduranceMult { get; set; } = 0;

        [SettingName("NPC Bonus Health Per Level")]
        [Tooltip("How much health npcs get for every level.")]
        public float fNPCHealthLevelBonus { get; set; } = 0;

        [SettingName("PC Bonus Health Per Level")]
        [Tooltip("How much health the player character gets for every level.")]
        public float fPCHealthLevelBonus { get; set; } = 0;

        [Tooltip("Entries that define the minimum and maximum health and resistance values for a given race.")]
        public List<ConfigRaceEntry> RaceEntries { get; set; } = new();

        [Tooltip("Entries that define additional stat scaling based on keywords, applied additively after other scaling is already finished.")]
        public List<KeywordScaleEntry> KeywordEntries { get; set; } = new();

        [Tooltip("Entries that define additional stat scaling based on factions, applied additively after other scaling is already finished.")]
        public List<FactionScaleEntry> FactionEntries { get; set; } = new();

        [Tooltip("Entries that define additional stat scaling based on perks, applied additively after other scaling is already finished.")]
        public List<PerkScaleEntry> PerkEntries { get; set; } = new();

        [Tooltip("This settings category applies to all NPCs with races not listed in the race entries list above.")]
        public StatScales GeneralScaling { get; set; } = new();

        [Tooltip("General modifiers for all NPCs which apply after all other balancing is already done. Just for general tuning, in case you like the values but would like them to be 15% lower or something. Quicker than manually changing all the entries.")]
        public StatScales ValueModifiers { get; set; } = new() { HealthScale = 1, HealthShift = 0 };
    }

    public class StatScales
    {
        public float HealthScale { get; set; } = 0.5f;
        public float HealthShift { get; set; } = 50.0f;
        public float DamageResistScale { get; set; } = 1.0f;
        public float DamageResistShift { get; set; } = 0.0f;
        public float EnergyResistScale { get; set; } = 1.0f;
        public float EnergyResistShift { get; set; } = 0.0f;
    }

    public class KeywordScaleEntry
    {
        public IFormLinkGetter<IKeywordGetter> Keyword { get; set; } = FormLink<IKeywordGetter>.Null;
        public StatScales KeywordScale { get; set; } = new() { HealthScale = 1, HealthShift = 0 };
    }

    public class FactionScaleEntry
    {
        public IFormLinkGetter<IFactionGetter> Faction { get; set; } = FormLink<IFactionGetter>.Null;
        public StatScales FactionScale { get; set; } = new() { HealthScale = 1, HealthShift = 0 };
    }

    public class PerkScaleEntry
    {
        public IFormLinkGetter<IPerkGetter> Perk { get; set; } = FormLink<IPerkGetter>.Null;
        public StatScales PerkScale { get; set; } = new() { HealthScale = 1, HealthShift = 0 };
    }

    public class ConfigRaceEntry
    {
        public List<IFormLinkGetter<IRaceGetter>> Races { get; set; } = new();

        public float MinimumHealth { get; set; } = -1;
        public float MaximumHealth { get; set; } = -1;
        public float MinimumPhysicalResist { get; set; } = -1;
        public float MaximumPhysicalResist { get; set; } = -1;
        public float MinimumEnergyResist { get; set; } = -1;
        public float MaximumEnergyResist { get; set; } = -1;
    }
}
