namespace Delta.Trinity.Hotfixes
{
    public partial class Artifact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UiBarOverlayColor { get; set; }
        public int UiBarBackgroundColor { get; set; }
        public int UiNameColor { get; set; }
        public short UiTextureKitId { get; set; }
        public short ChrSpecializationId { get; set; }
        public byte ArtifactCategoryId { get; set; }
        public byte Flags { get; set; }
        public int UiModelSceneId { get; set; }
        public int SpellVisualKitId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
