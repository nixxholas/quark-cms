namespace Delta.Trinity.Hotfixes
{
    public partial class Mount
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SourceText { get; set; }
        public int SourceSpellId { get; set; }
        public float MountFlyRideHeight { get; set; }
        public short MountTypeId { get; set; }
        public short Flags { get; set; }
        public byte SourceTypeEnum { get; set; }
        public int Id { get; set; }
        public int PlayerConditionId { get; set; }
        public int UiModelSceneId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
