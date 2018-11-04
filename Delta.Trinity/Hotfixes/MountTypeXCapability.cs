namespace Delta.Trinity.Hotfixes
{
    public partial class MountTypeXCapability
    {
        public int Id { get; set; }
        public short MountTypeId { get; set; }
        public short MountCapabilityId { get; set; }
        public byte OrderIndex { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
