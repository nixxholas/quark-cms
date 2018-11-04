namespace Delta.Trinity.Characters
{
    public partial class ItemInstance
    {
        public long Guid { get; set; }
        public int ItemEntry { get; set; }
        public long OwnerGuid { get; set; }
        public long CreatorGuid { get; set; }
        public long GiftCreatorGuid { get; set; }
        public int Count { get; set; }
        public int Duration { get; set; }
        public string Charges { get; set; }
        public int Flags { get; set; }
        public string Enchantments { get; set; }
        public byte RandomPropertyType { get; set; }
        public int RandomPropertyId { get; set; }
        public short Durability { get; set; }
        public int PlayedTime { get; set; }
        public string Text { get; set; }
        public int Transmogrification { get; set; }
        public int UpgradeId { get; set; }
        public int EnchantIllusion { get; set; }
        public int BattlePetSpeciesId { get; set; }
        public int BattlePetBreedData { get; set; }
        public short BattlePetLevel { get; set; }
        public int BattlePetDisplayId { get; set; }
        public byte Context { get; set; }
        public string BonusListIds { get; set; }
    }
}
