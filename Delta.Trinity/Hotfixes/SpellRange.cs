namespace Delta.Trinity.Hotfixes
{
    public partial class SpellRange
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string DisplayNameShort { get; set; }
        public float RangeMin1 { get; set; }
        public float RangeMin2 { get; set; }
        public float RangeMax1 { get; set; }
        public float RangeMax2 { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
