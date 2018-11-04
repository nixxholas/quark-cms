namespace Delta.Trinity.Characters
{
    public partial class CharacterCurrency
    {
        public long CharacterGuid { get; set; }
        public short Currency { get; set; }
        public int Quantity { get; set; }
        public int WeeklyQuantity { get; set; }
        public int TrackedQuantity { get; set; }
        public byte Flags { get; set; }
    }
}
