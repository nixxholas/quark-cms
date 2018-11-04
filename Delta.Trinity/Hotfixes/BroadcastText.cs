namespace Delta.Trinity.Hotfixes
{
    public partial class BroadcastText
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Text1 { get; set; }
        public short EmoteId1 { get; set; }
        public short EmoteId2 { get; set; }
        public short EmoteId3 { get; set; }
        public short EmoteDelay1 { get; set; }
        public short EmoteDelay2 { get; set; }
        public short EmoteDelay3 { get; set; }
        public short EmotesId { get; set; }
        public byte LanguageId { get; set; }
        public byte Flags { get; set; }
        public int ConditionId { get; set; }
        public int SoundEntriesId1 { get; set; }
        public int SoundEntriesId2 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
