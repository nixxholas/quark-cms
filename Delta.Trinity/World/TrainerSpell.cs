namespace Delta.Trinity.World
{
    public partial class TrainerSpell
    {
        public int TrainerId { get; set; }
        public int SpellId { get; set; }
        public int MoneyCost { get; set; }
        public int ReqSkillLine { get; set; }
        public int ReqSkillRank { get; set; }
        public int ReqAbility1 { get; set; }
        public int ReqAbility2 { get; set; }
        public int ReqAbility3 { get; set; }
        public byte ReqLevel { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
