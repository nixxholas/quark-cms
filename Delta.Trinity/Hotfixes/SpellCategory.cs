namespace Delta.Trinity.Hotfixes
{
    public partial class SpellCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ChargeRecoveryTime { get; set; }
        public byte Flags { get; set; }
        public byte UsesPerWeek { get; set; }
        public byte MaxCharges { get; set; }
        public int TypeMask { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
