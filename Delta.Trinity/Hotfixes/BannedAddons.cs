﻿namespace Delta.Trinity.Hotfixes
{
    public partial class BannedAddons
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public byte Flags { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
