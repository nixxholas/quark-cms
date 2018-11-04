namespace Delta.Trinity.Hotfixes
{
    public partial class HotfixData
    {
        public int Id { get; set; }
        public int TableHash { get; set; }
        public int RecordId { get; set; }
        public byte? Deleted { get; set; }
    }
}
