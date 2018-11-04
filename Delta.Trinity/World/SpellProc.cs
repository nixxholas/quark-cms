namespace Delta.Trinity.World
{
    public partial class SpellProc
    {
        public int SpellId { get; set; }
        public byte SchoolMask { get; set; }
        public short SpellFamilyName { get; set; }
        public int SpellFamilyMask0 { get; set; }
        public int SpellFamilyMask1 { get; set; }
        public int SpellFamilyMask2 { get; set; }
        public int SpellFamilyMask3 { get; set; }
        public int ProcFlags { get; set; }
        public int SpellTypeMask { get; set; }
        public int SpellPhaseMask { get; set; }
        public int HitMask { get; set; }
        public int AttributesMask { get; set; }
        public float ProcsPerMinute { get; set; }
        public float Chance { get; set; }
        public int Cooldown { get; set; }
        public byte Charges { get; set; }
    }
}
