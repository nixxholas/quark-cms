namespace Delta.Trinity.Hotfixes
{
    public partial class SpellLocale
    {
        public int Id { get; set; }
        public string Locale { get; set; }
        public string NameLang { get; set; }
        public string NameSubtextLang { get; set; }
        public string DescriptionLang { get; set; }
        public string AuraDescriptionLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
