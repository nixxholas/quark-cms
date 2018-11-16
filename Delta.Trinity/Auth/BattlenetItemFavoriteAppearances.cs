namespace Delta.Trinity.Auth
{
    public partial class BattlenetItemFavoriteAppearances
    {
        public int BattlenetAccountId { get; set; }
        public int ItemModifiedAppearanceId { get; set; }

        public virtual BattlenetAccount BattlenetAccount { get; set; }
    }
}
