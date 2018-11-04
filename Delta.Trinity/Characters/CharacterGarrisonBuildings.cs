namespace Delta.Trinity.Characters
{
    public partial class CharacterGarrisonBuildings
    {
        public long Guid { get; set; }
        public int PlotInstanceId { get; set; }
        public int BuildingId { get; set; }
        public long TimeBuilt { get; set; }
        public byte Active { get; set; }
    }
}
