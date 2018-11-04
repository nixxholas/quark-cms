namespace Delta.Trinity.World
{
    public partial class ConversationTemplate
    {
        public int Id { get; set; }
        public int FirstLineId { get; set; }
        public int LastLineEndTime { get; set; }
        public string ScriptName { get; set; }
        public int VerifiedBuild { get; set; }
    }
}
