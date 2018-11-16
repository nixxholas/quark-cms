namespace Delta.Trinity.Auth
{
    public partial class BattlenetItemAppearances
    {
        public int BattlenetAccountId { get; set; }
        public short BlobIndex { get; set; }
        public int AppearanceMask { get; set; }

        public virtual BattlenetAccount BattlenetAccount { get; set; }
    }
}
