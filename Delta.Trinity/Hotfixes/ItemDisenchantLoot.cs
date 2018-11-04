namespace Delta.Trinity.Hotfixes
{
    public partial class ItemDisenchantLoot
    {
        public int Id { get; set; }
        public short MinLevel { get; set; }
        public short MaxLevel { get; set; }
        public short SkillRequired { get; set; }
        public byte Subclass { get; set; }
        public byte Quality { get; set; }
        public byte ExpansionId { get; set; }
        public byte Class { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
