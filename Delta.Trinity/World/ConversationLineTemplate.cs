namespace Delta.Trinity.World
{
    public partial class ConversationLineTemplate
    {
        public int Id { get; set; }
        public int StartTime { get; set; }
        public int UiCameraId { get; set; }
        public byte ActorIdx { get; set; }
        public byte Flags { get; set; }
        public int VerifiedBuild { get; set; }
    }
}
