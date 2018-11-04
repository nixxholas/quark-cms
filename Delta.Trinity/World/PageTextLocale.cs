namespace Delta.Trinity.World
{
    public partial class PageTextLocale
    {
        public int Id { get; set; }
        public string Locale { get; set; }
        public string Text { get; set; }
        public short? VerifiedBuild { get; set; }
    }
}
