namespace Delta.Trinity.Hotfixes
{
    public partial class PowerType
    {
        public int Id { get; set; }
        public string NameGlobalStringTag { get; set; }
        public string CostGlobalStringTag { get; set; }
        public float RegenPeace { get; set; }
        public float RegenCombat { get; set; }
        public short MaxBasePower { get; set; }
        public short RegenInterruptTimeMs { get; set; }
        public short Flags { get; set; }
        public byte PowerTypeEnum { get; set; }
        public byte MinPower { get; set; }
        public byte CenterPower { get; set; }
        public byte DefaultPower { get; set; }
        public byte DisplayModifier { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
