namespace Delta.Trinity.Auth
{
    public partial class AccountLastPlayedCharacter
    {
        public int AccountId { get; set; }
        public byte Region { get; set; }
        public byte Battlegroup { get; set; }
        public int? RealmId { get; set; }
        public string CharacterName { get; set; }
        public long? CharacterGuid { get; set; }
        public int? LastPlayedTime { get; set; }
    }
}
