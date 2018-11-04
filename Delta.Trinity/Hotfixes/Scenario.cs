namespace Delta.Trinity.Hotfixes
{
    public partial class Scenario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short AreaTableId { get; set; }
        public byte Flags { get; set; }
        public byte Type { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
