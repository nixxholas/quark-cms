namespace Delta.Trinity.Hotfixes
{
    public partial class SkillLineAbility
    {
        public long RaceMask { get; set; }
        public int Id { get; set; }
        public int Spell { get; set; }
        public int SupercedesSpell { get; set; }
        public short SkillLine { get; set; }
        public short TrivialSkillLineRankHigh { get; set; }
        public short TrivialSkillLineRankLow { get; set; }
        public short UniqueBit { get; set; }
        public short TradeSkillCategoryId { get; set; }
        public byte NumSkillUps { get; set; }
        public int ClassMask { get; set; }
        public short MinSkillLineRank { get; set; }
        public byte AcquireMethod { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
