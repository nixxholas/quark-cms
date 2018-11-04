namespace Delta.Trinity.Hotfixes
{
    public partial class ArtifactAppearance
    {
        public string Name { get; set; }
        public int UiSwatchColor { get; set; }
        public float UiModelSaturation { get; set; }
        public float UiModelOpacity { get; set; }
        public int OverrideShapeshiftDisplayId { get; set; }
        public short ArtifactAppearanceSetId { get; set; }
        public short UiCameraId { get; set; }
        public byte DisplayIndex { get; set; }
        public byte ItemAppearanceModifierId { get; set; }
        public byte Flags { get; set; }
        public byte OverrideShapeshiftFormId { get; set; }
        public int Id { get; set; }
        public int UnlockPlayerConditionId { get; set; }
        public int UiItemAppearanceId { get; set; }
        public int UiAltItemAppearanceId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
