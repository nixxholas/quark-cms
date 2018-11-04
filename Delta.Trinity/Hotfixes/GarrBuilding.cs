namespace Delta.Trinity.Hotfixes
{
    public partial class GarrBuilding
    {
        public int Id { get; set; }
        public string AllianceName { get; set; }
        public string HordeName { get; set; }
        public string Description { get; set; }
        public string Tooltip { get; set; }
        public int HordeGameObjectId { get; set; }
        public int AllianceGameObjectId { get; set; }
        public int IconFileDataId { get; set; }
        public short CurrencyTypeId { get; set; }
        public short HordeUiTextureKitId { get; set; }
        public short AllianceUiTextureKitId { get; set; }
        public short AllianceSceneScriptPackageId { get; set; }
        public short HordeSceneScriptPackageId { get; set; }
        public short GarrAbilityId { get; set; }
        public short BonusGarrAbilityId { get; set; }
        public short GoldCost { get; set; }
        public byte GarrSiteId { get; set; }
        public byte BuildingType { get; set; }
        public byte UpgradeLevel { get; set; }
        public byte Flags { get; set; }
        public byte ShipmentCapacity { get; set; }
        public byte GarrTypeId { get; set; }
        public int BuildSeconds { get; set; }
        public int CurrencyQty { get; set; }
        public int MaxAssignments { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
