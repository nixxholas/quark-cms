namespace Delta.Trinity.Hotfixes
{
    public partial class PrestigeLevelInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BadgeTextureFileDataId { get; set; }
        public byte PrestigeLevel { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
