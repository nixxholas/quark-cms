namespace Delta.Trinity.Hotfixes
{
    public partial class Emotes
    {
        public int Id { get; set; }
        public long RaceMask { get; set; }
        public string EmoteSlashCommand { get; set; }
        public int EmoteFlags { get; set; }
        public int SpellVisualKitId { get; set; }
        public short AnimId { get; set; }
        public byte EmoteSpecProc { get; set; }
        public int ClassMask { get; set; }
        public int EmoteSpecProcParam { get; set; }
        public int EventSoundId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
