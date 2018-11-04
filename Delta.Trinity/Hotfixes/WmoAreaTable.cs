namespace Delta.Trinity.Hotfixes
{
    public partial class WmoAreaTable
    {
        public string AreaName { get; set; }
        public int WmoGroupId { get; set; }
        public short AmbienceId { get; set; }
        public short ZoneMusic { get; set; }
        public short IntroSound { get; set; }
        public short AreaTableId { get; set; }
        public short UwIntroSound { get; set; }
        public short UwAmbience { get; set; }
        public byte NameSetId { get; set; }
        public byte SoundProviderPref { get; set; }
        public byte SoundProviderPrefUnderwater { get; set; }
        public byte Flags { get; set; }
        public int Id { get; set; }
        public int UwZoneMusic { get; set; }
        public short WmoId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
