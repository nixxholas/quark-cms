namespace Delta.Trinity.Hotfixes
{
    public partial class GarrFollower
    {
        public string HordeSourceText { get; set; }
        public string AllianceSourceText { get; set; }
        public string TitleName { get; set; }
        public int HordeCreatureId { get; set; }
        public int AllianceCreatureId { get; set; }
        public int HordeIconFileDataId { get; set; }
        public int AllianceIconFileDataId { get; set; }
        public int HordeSlottingBroadcastTextId { get; set; }
        public int AllySlottingBroadcastTextId { get; set; }
        public short HordeGarrFollItemSetId { get; set; }
        public short AllianceGarrFollItemSetId { get; set; }
        public short ItemLevelWeapon { get; set; }
        public short ItemLevelArmor { get; set; }
        public short HordeUitextureKitId { get; set; }
        public short AllianceUitextureKitId { get; set; }
        public byte GarrFollowerTypeId { get; set; }
        public byte HordeGarrFollRaceId { get; set; }
        public byte AllianceGarrFollRaceId { get; set; }
        public byte Quality { get; set; }
        public byte HordeGarrClassSpecId { get; set; }
        public byte AllianceGarrClassSpecId { get; set; }
        public byte FollowerLevel { get; set; }
        public byte Gender { get; set; }
        public byte Flags { get; set; }
        public byte HordeSourceTypeEnum { get; set; }
        public byte AllianceSourceTypeEnum { get; set; }
        public byte GarrTypeId { get; set; }
        public byte Vitality { get; set; }
        public byte ChrClassId { get; set; }
        public byte HordeFlavorGarrStringId { get; set; }
        public byte AllianceFlavorGarrStringId { get; set; }
        public int Id { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
