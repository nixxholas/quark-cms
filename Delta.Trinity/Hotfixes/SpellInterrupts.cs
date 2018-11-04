namespace Delta.Trinity.Hotfixes
{
    public partial class SpellInterrupts
    {
        public int Id { get; set; }
        public byte DifficultyId { get; set; }
        public short InterruptFlags { get; set; }
        public int AuraInterruptFlags1 { get; set; }
        public int AuraInterruptFlags2 { get; set; }
        public int ChannelInterruptFlags1 { get; set; }
        public int ChannelInterruptFlags2 { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
