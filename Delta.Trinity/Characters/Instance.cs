namespace Delta.Trinity.Characters
{
    public partial class Instance
    {
        public int Id { get; set; }
        public short Map { get; set; }
        public int Resettime { get; set; }
        public byte Difficulty { get; set; }
        public int CompletedEncounters { get; set; }
        public string Data { get; set; }
        public int EntranceId { get; set; }
    }
}
