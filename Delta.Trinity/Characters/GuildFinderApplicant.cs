namespace Delta.Trinity.Characters
{
    public partial class GuildFinderApplicant
    {
        public long GuildId { get; set; }
        public long PlayerGuid { get; set; }
        public byte? Availability { get; set; }
        public byte? ClassRole { get; set; }
        public byte? Interests { get; set; }
        public string Comment { get; set; }
        public int? SubmitTime { get; set; }
    }
}
