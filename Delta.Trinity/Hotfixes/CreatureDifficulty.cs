namespace Delta.Trinity.Hotfixes
{
    public partial class CreatureDifficulty
    {
        public int Id { get; set; }
        public int CreatureId { get; set; }
        public int Flags1 { get; set; }
        public int Flags2 { get; set; }
        public int Flags3 { get; set; }
        public int Flags4 { get; set; }
        public int Flags5 { get; set; }
        public int Flags6 { get; set; }
        public int Flags7 { get; set; }
        public short FactionTemplateId { get; set; }
        public byte Expansion { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
