namespace Delta.Trinity.Characters
{
    public partial class CharacterAccountData
    {
        public long Guid { get; set; }
        public byte Type { get; set; }
        public int Time { get; set; }
        public byte[] Data { get; set; }
    }
}
