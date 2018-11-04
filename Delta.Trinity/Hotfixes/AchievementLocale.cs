namespace Delta.Trinity.Hotfixes
{
    public partial class AchievementLocale
    {
        public int Id { get; set; }
        public string Locale { get; set; }
        public string TitleLang { get; set; }
        public string DescriptionLang { get; set; }
        public string RewardLang { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
