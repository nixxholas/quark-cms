namespace Delta.Trinity.Hotfixes
{
    public partial class SpellProcsPerMinuteMod
    {
        public int Id { get; set; }
        public float Coeff { get; set; }
        public short Param { get; set; }
        public byte Type { get; set; }
        public short SpellProcsPerMinuteId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
