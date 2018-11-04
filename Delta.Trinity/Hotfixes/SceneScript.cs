namespace Delta.Trinity.Hotfixes
{
    public partial class SceneScript
    {
        public int Id { get; set; }
        public short FirstSceneScriptId { get; set; }
        public short NextSceneScriptId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
