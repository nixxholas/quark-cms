namespace Delta.Trinity.Hotfixes
{
    public partial class TotemCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotemCategoryMask { get; set; }
        public byte TotemCategoryType { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
