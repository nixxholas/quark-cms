namespace Delta.Trinity.Hotfixes
{
    public partial class SpellClassOptions
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int SpellClassMask1 { get; set; }
        public int SpellClassMask2 { get; set; }
        public int SpellClassMask3 { get; set; }
        public int SpellClassMask4 { get; set; }
        public byte SpellClassSet { get; set; }
        public int ModalNextSpell { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
