namespace Delta.Trinity.World
{
    public partial class QuestGreeting
    {
        public int Id { get; set; }
        public byte Type { get; set; }
        public short GreetEmoteType { get; set; }
        public int GreetEmoteDelay { get; set; }
        public string Greeting { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
