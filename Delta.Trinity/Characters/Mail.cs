namespace Delta.Trinity.Characters
{
    public partial class Mail
    {
        public int Id { get; set; }
        public byte MessageType { get; set; }
        public byte Stationery { get; set; }
        public short MailTemplateId { get; set; }
        public long Sender { get; set; }
        public long Receiver { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public byte HasItems { get; set; }
        public int ExpireTime { get; set; }
        public int DeliverTime { get; set; }
        public long Money { get; set; }
        public long Cod { get; set; }
        public byte Checked { get; set; }
    }
}
