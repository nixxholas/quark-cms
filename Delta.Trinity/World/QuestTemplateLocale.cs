namespace Delta.Trinity.World
{
    public partial class QuestTemplateLocale
    {
        public int Id { get; set; }
        public string Locale { get; set; }
        public string LogTitle { get; set; }
        public string LogDescription { get; set; }
        public string QuestDescription { get; set; }
        public string AreaDescription { get; set; }
        public string PortraitGiverText { get; set; }
        public string PortraitGiverName { get; set; }
        public string PortraitTurnInText { get; set; }
        public string PortraitTurnInName { get; set; }
        public string QuestCompletionLog { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
