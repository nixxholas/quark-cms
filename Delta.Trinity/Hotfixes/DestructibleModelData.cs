namespace Delta.Trinity.Hotfixes
{
    public partial class DestructibleModelData
    {
        public int Id { get; set; }
        public short State0Wmo { get; set; }
        public short State1Wmo { get; set; }
        public short State2Wmo { get; set; }
        public short State3Wmo { get; set; }
        public short HealEffectSpeed { get; set; }
        public byte State0ImpactEffectDoodadSet { get; set; }
        public byte State0AmbientDoodadSet { get; set; }
        public byte State0NameSet { get; set; }
        public byte State1DestructionDoodadSet { get; set; }
        public byte State1ImpactEffectDoodadSet { get; set; }
        public byte State1AmbientDoodadSet { get; set; }
        public byte State1NameSet { get; set; }
        public byte State2DestructionDoodadSet { get; set; }
        public byte State2ImpactEffectDoodadSet { get; set; }
        public byte State2AmbientDoodadSet { get; set; }
        public byte State2NameSet { get; set; }
        public byte State3InitDoodadSet { get; set; }
        public byte State3AmbientDoodadSet { get; set; }
        public byte State3NameSet { get; set; }
        public byte EjectDirection { get; set; }
        public byte DoNotHighlight { get; set; }
        public byte HealEffect { get; set; }
        public short VerifiedBuild { get; set; }
    }
}
