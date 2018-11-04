namespace Delta.Trinity.Hotfixes
{
    public partial class TransportRotation
    {
        public int Id { get; set; }
        public int TimeIndex { get; set; }
        public float Rot1 { get; set; }
        public float Rot2 { get; set; }
        public float Rot3 { get; set; }
        public float Rot4 { get; set; }
        public int GameObjectsId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
