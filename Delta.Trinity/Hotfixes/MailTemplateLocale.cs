namespace Delta.Trinity.Hotfixes
{
    public partial class MailTemplateLocale
    {
        public int Id { get; set; }
        public string Locale { get; set; }
        public string BodyLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
