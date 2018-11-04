namespace Delta.Trinity.Hotfixes
{
    public partial class AreaTable
    {
        public int Id { get; set; }
        public string ZoneName { get; set; }
        public string AreaName { get; set; }
        public int Flags1 { get; set; }
        public int Flags2 { get; set; }
        public float AmbientMultiplier { get; set; }
        public short ContinentId { get; set; }
        public short ParentAreaId { get; set; }
        public short AreaBit { get; set; }
        public short AmbienceId { get; set; }
        public short ZoneMusic { get; set; }
        public short IntroSound { get; set; }
        public short LiquidTypeId1 { get; set; }
        public short LiquidTypeId2 { get; set; }
        public short LiquidTypeId3 { get; set; }
        public short LiquidTypeId4 { get; set; }
        public short UwZoneMusic { get; set; }
        public short UwAmbience { get; set; }
        public short PvpCombatWorldStateId { get; set; }
        public byte SoundProviderPref { get; set; }
        public byte SoundProviderPrefUnderwater { get; set; }
        public byte ExplorationLevel { get; set; }
        public byte FactionGroupMask { get; set; }
        public byte MountFlags { get; set; }
        public byte WildBattlePetLevelMin { get; set; }
        public byte WildBattlePetLevelMax { get; set; }
        public byte WindSettingsId { get; set; }
        public int UwIntroSound { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
