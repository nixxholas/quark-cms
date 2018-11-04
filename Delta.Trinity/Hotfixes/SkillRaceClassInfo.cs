namespace Delta.Trinity.Hotfixes
{
    public partial class SkillRaceClassInfo
    {
        public int Id { get; set; }
        public long RaceMask { get; set; }
        public short SkillId { get; set; }
        public short Flags { get; set; }
        public short SkillTierId { get; set; }
        public byte Availability { get; set; }
        public byte MinLevel { get; set; }
        public int ClassMask { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
