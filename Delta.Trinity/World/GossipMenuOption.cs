namespace Delta.Trinity.World
{
    public partial class GossipMenuOption
    {
        public int MenuId { get; set; }
        public int OptionIndex { get; set; }
        public byte OptionIcon { get; set; }
        public string OptionText { get; set; }
        public int OptionBroadcastTextId { get; set; }
        public int OptionType { get; set; }
        public long OptionNpcFlag { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
