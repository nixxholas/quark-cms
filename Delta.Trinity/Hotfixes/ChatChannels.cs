namespace Delta.Trinity.Hotfixes
{
    public partial class ChatChannels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public int Flags { get; set; }
        public byte FactionGroup { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
