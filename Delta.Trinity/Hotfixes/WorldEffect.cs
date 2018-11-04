namespace Delta.Trinity.Hotfixes
{
    public partial class WorldEffect
    {
        public int Id { get; set; }
        public int TargetAsset { get; set; }
        public short CombatConditionId { get; set; }
        public byte TargetType { get; set; }
        public byte WhenToDisplay { get; set; }
        public int QuestFeedbackEffectId { get; set; }
        public int PlayerConditionId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
