namespace Delta.Trinity.World
{
    public partial class Trainer
    {
        public int Id { get; set; }
        public byte Type { get; set; }
        public string Greeting { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
