namespace Delta.Trinity.World
{
    public partial class PoolPool
    {
        public int PoolId { get; set; }
        public int MotherPool { get; set; }
        public float Chance { get; set; }
        public string Description { get; set; }
    }
}
