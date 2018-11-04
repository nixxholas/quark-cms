namespace Delta.Trinity.Hotfixes
{
    public partial class Difficulty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short GroupSizeHealthCurveId { get; set; }
        public short GroupSizeDmgCurveId { get; set; }
        public short GroupSizeSpellPointsCurveId { get; set; }
        public byte FallbackDifficultyId { get; set; }
        public byte InstanceType { get; set; }
        public byte MinPlayers { get; set; }
        public byte MaxPlayers { get; set; }
        public byte OldEnumValue { get; set; }
        public byte Flags { get; set; }
        public byte ToggleDifficultyId { get; set; }
        public byte ItemContext { get; set; }
        public byte OrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
