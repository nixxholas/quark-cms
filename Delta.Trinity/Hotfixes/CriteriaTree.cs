namespace Delta.Trinity.Hotfixes
{
    public partial class CriteriaTree
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public short Flags { get; set; }
        public byte Operator { get; set; }
        public int CriteriaId { get; set; }
        public int Parent { get; set; }
        public int OrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
