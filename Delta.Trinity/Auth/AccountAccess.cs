namespace Delta.Trinity.Auth
{
    public partial class AccountAccess
    {
        public AccountAccess() {}

        public AccountAccess(byte gmLevel, int realmId)
        {
            Gmlevel = gmLevel;
            RealmId = realmId;
        }
        
        public int Id { get; set; }
        public byte Gmlevel { get; set; }
        public int RealmId { get; set; }
    }
}
