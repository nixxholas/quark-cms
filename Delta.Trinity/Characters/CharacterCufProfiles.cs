namespace Delta.Trinity.Characters
{
    public partial class CharacterCufProfiles
    {
        public long Guid { get; set; }
        public byte Id { get; set; }
        public string Name { get; set; }
        public short FrameHeight { get; set; }
        public short FrameWidth { get; set; }
        public byte SortBy { get; set; }
        public byte HealthText { get; set; }
        public int BoolOptions { get; set; }
        public byte TopPoint { get; set; }
        public byte BottomPoint { get; set; }
        public byte LeftPoint { get; set; }
        public short TopOffset { get; set; }
        public short BottomOffset { get; set; }
        public short LeftOffset { get; set; }
    }
}
