namespace Delta.Trinity.World
{
    public partial class Playerchoice
    {
        public int ChoiceId { get; set; }
        public int UiTextureKitId { get; set; }
        public string Question { get; set; }
        public byte HideWarboardHeader { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
