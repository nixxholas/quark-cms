namespace Delta.Trinity.Hotfixes
{
    public partial class SpellTotems
    {
        public int Id { get; set; }
        public int SpellId { get; set; }
        public int Totem1 { get; set; }
        public int Totem2 { get; set; }
        public short RequiredTotemCategoryId1 { get; set; }
        public short RequiredTotemCategoryId2 { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
