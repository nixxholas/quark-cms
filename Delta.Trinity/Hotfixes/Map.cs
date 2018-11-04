namespace Delta.Trinity.Hotfixes
{
    public partial class Map
    {
        public int Id { get; set; }
        public string Directory { get; set; }
        public string MapName { get; set; }
        public string MapDescription0 { get; set; }
        public string MapDescription1 { get; set; }
        public string PvpShortDescription { get; set; }
        public string PvpLongDescription { get; set; }
        public int Flags1 { get; set; }
        public int Flags2 { get; set; }
        public float MinimapIconScale { get; set; }
        public float CorpseX { get; set; }
        public float CorpseY { get; set; }
        public short AreaTableId { get; set; }
        public short LoadingScreenId { get; set; }
        public short CorpseMapId { get; set; }
        public short TimeOfDayOverride { get; set; }
        public short ParentMapId { get; set; }
        public short CosmeticParentMapId { get; set; }
        public short WindSettingsId { get; set; }
        public byte InstanceType { get; set; }
        public byte MapType { get; set; }
        public byte ExpansionId { get; set; }
        public byte MaxPlayers { get; set; }
        public byte TimeOffset { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
