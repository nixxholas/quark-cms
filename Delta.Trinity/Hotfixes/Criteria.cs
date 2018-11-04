namespace Delta.Trinity.Hotfixes
{
    public partial class Criteria
    {
        public int Id { get; set; }
        public int Asset { get; set; }
        public int StartAsset { get; set; }
        public int FailAsset { get; set; }
        public int ModifierTreeId { get; set; }
        public short StartTimer { get; set; }
        public short EligibilityWorldStateId { get; set; }
        public byte Type { get; set; }
        public byte StartEvent { get; set; }
        public byte FailEvent { get; set; }
        public byte Flags { get; set; }
        public byte EligibilityWorldStateValue { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
