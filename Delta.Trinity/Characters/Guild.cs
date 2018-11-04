namespace Delta.Trinity.Characters
{
    public partial class Guild
    {
        public long Guildid { get; set; }
        public string Name { get; set; }
        public long Leaderguid { get; set; }
        public byte EmblemStyle { get; set; }
        public byte EmblemColor { get; set; }
        public byte BorderStyle { get; set; }
        public byte BorderColor { get; set; }
        public byte BackgroundColor { get; set; }
        public string Info { get; set; }
        public string Motd { get; set; }
        public int Createdate { get; set; }
        public long BankMoney { get; set; }
    }
}
