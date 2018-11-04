namespace Delta.Trinity.Hotfixes
{
    public partial class SkillLine
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string AlternateVerb { get; set; }
        public short Flags { get; set; }
        public byte CategoryId { get; set; }
        public byte CanLink { get; set; }
        public int SpellIconFileId { get; set; }
        public int ParentSkillLineId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
