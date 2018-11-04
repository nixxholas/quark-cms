namespace Delta.Trinity.Hotfixes
{
    public partial class SpellCooldowns
    {
        public int Id { get; set; }
        public int CategoryRecoveryTime { get; set; }
        public int RecoveryTime { get; set; }
        public int StartRecoveryTime { get; set; }
        public byte DifficultyId { get; set; }
        public int SpellId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
