namespace Delta.Trinity.World
{
    public partial class QuestGreetingLocale
    {
        public int Id { get; set; }
        public byte Type { get; set; }
        public string Locale { get; set; }
        public string Greeting { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
