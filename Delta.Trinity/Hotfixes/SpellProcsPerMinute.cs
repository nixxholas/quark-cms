namespace Delta.Trinity.Hotfixes
{
    public partial class SpellProcsPerMinute
    {
        public int Id { get; set; }
        public float BaseProcRate { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
