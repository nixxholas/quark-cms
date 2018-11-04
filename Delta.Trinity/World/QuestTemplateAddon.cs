namespace Delta.Trinity.World
{
    public partial class QuestTemplateAddon
    {
        public int Id { get; set; }
        public byte MaxLevel { get; set; }
        public int AllowableClasses { get; set; }
        public int SourceSpellId { get; set; }
        public int PrevQuestId { get; set; }
        public int NextQuestId { get; set; }
        public int ExclusiveGroup { get; set; }
        public int RewardMailTemplateId { get; set; }
        public int RewardMailDelay { get; set; }
        public short RequiredSkillId { get; set; }
        public short RequiredSkillPoints { get; set; }
        public short RequiredMinRepFaction { get; set; }
        public short RequiredMaxRepFaction { get; set; }
        public int RequiredMinRepValue { get; set; }
        public int RequiredMaxRepValue { get; set; }
        public byte ProvidedItemCount { get; set; }
        public byte SpecialFlags { get; set; }
        public string ScriptName { get; set; }
    }
}
