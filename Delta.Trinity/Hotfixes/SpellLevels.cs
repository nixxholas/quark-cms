namespace Delta.Trinity.Hotfixes
{
    public partial class SpellLevels
    {
        public int Id { get; set; }
        public short BaseLevel { get; set; }
        public short MaxLevel { get; set; }
        public short SpellLevel { get; set; }
        public byte DifficultyId { get; set; }
        public byte MaxPassiveAuraLevel { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
