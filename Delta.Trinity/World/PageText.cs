namespace Delta.Trinity.World
{
    public partial class PageText
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int NextPageId { get; set; }
        public int PlayerConditionId { get; set; }
        public byte Flags { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
