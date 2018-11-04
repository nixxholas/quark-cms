namespace Delta.Trinity.Hotfixes
{
    public partial class TaxiPath
    {
        public short FromTaxiNode { get; set; }
        public short ToTaxiNode { get; set; }
        public int Id { get; set; }
        public int Cost { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
