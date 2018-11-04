namespace Delta.Trinity.Hotfixes
{
    public partial class GarrAbility
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int IconFileDataId { get; set; }
        public short Flags { get; set; }
        public short FactionChangeGarrAbilityId { get; set; }
        public byte GarrAbilityCategoryId { get; set; }
        public byte GarrFollowerTypeId { get; set; }
        public int Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
