namespace Delta.Trinity.Characters
{
    public partial class CalendarInvites
    {
        public long InviteId { get; set; }
        public long EventId { get; set; }
        public long Invitee { get; set; }
        public long Sender { get; set; }
        public byte Status { get; set; }
        public int ResponseTime { get; set; }
        public byte ModerationRank { get; set; }
        public string Note { get; set; }
    }
}
