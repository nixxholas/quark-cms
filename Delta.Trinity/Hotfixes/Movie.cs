namespace Delta.Trinity.Hotfixes
{
    public partial class Movie
    {
        public int Id { get; set; }
        public int AudioFileDataId { get; set; }
        public int SubtitleFileDataId { get; set; }
        public byte Volume { get; set; }
        public byte KeyId { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
