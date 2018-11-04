namespace Delta.Trinity.Hotfixes
{
    public partial class MapDifficulty
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public byte DifficultyId { get; set; }
        public byte ResetInterval { get; set; }
        public byte MaxPlayers { get; set; }
        public byte LockId { get; set; }
        public byte Flags { get; set; }
        public byte ItemContext { get; set; }
        public int ItemContextPickerId { get; set; }
        public short MapId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
