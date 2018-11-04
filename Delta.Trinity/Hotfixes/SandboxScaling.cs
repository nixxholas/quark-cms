namespace Delta.Trinity.Hotfixes
{
    public partial class SandboxScaling
    {
        public int Id { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
        public int Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
