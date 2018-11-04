namespace Delta.Trinity.Characters
{
    public partial class CalendarEvents
    {
        public long EventId { get; set; }
        public long Owner { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte EventType { get; set; }
        public int TextureId { get; set; }
        public int Date { get; set; }
        public int Flags { get; set; }
        public int LockDate { get; set; }
    }
}
