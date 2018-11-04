namespace Delta.Trinity.Characters
{
    public partial class CharacterInventory
    {
        public long Guid { get; set; }
        public long Bag { get; set; }
        public byte Slot { get; set; }
        public long Item { get; set; }
    }
}
