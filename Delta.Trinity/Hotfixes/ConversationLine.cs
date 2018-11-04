namespace Delta.Trinity.Hotfixes
{
    public partial class ConversationLine
    {
        public int Id { get; set; }
        public int BroadcastTextId { get; set; }
        public int SpellVisualKitId { get; set; }
        public int AdditionalDuration { get; set; }
        public short NextConversationLineId { get; set; }
        public short AnimKitId { get; set; }
        public byte SpeechType { get; set; }
        public byte StartAnimation { get; set; }
        public byte EndAnimation { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
