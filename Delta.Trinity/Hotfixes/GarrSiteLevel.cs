namespace Delta.Trinity.Hotfixes
{
    public partial class GarrSiteLevel
    {
        public int Id { get; set; }
        public float TownHallUiPosX { get; set; }
        public float TownHallUiPosY { get; set; }
        public short MapId { get; set; }
        public short UiTextureKitId { get; set; }
        public short UpgradeMovieId { get; set; }
        public short UpgradeCost { get; set; }
        public short UpgradeGoldCost { get; set; }
        public byte GarrLevel { get; set; }
        public byte GarrSiteId { get; set; }
        public byte MaxBuildingLevel { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
