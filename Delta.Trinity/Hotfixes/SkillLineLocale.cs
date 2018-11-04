namespace Delta.Trinity.Hotfixes
{
    public partial class SkillLineLocale
    {
        public int Id { get; set; }
        public string Locale { get; set; }
        public string DisplayNameLang { get; set; }
        public string DescriptionLang { get; set; }
        public string AlternateVerbLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
