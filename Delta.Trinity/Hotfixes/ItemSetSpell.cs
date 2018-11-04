namespace Delta.Trinity.Hotfixes
{
    public partial class ItemSetSpell
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public short ChrSpecId { get; set; }
        public byte Threshold { get; set; }
        public short ItemSetId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
