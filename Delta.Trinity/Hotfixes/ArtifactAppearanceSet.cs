namespace Delta.Trinity.Hotfixes
{
    public partial class ArtifactAppearanceSet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public short UiCameraId { get; set; }
        public short AltHandUicameraId { get; set; }
        public byte DisplayIndex { get; set; }
        public byte ForgeAttachmentOverride { get; set; }
        public byte Flags { get; set; }
        public int Id { get; set; }
        public byte ArtifactId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
