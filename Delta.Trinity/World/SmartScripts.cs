namespace Delta.Trinity.World
{
    public partial class SmartScripts
    {
        public long Entryorguid { get; set; }
        public byte SourceType { get; set; }
        public short Id { get; set; }
        public short Link { get; set; }
        public byte EventType { get; set; }
        public byte EventPhaseMask { get; set; }
        public byte EventChance { get; set; }
        public short EventFlags { get; set; }
        public int EventParam1 { get; set; }
        public int EventParam2 { get; set; }
        public int EventParam3 { get; set; }
        public int EventParam4 { get; set; }
        public string EventParamString { get; set; }
        public byte ActionType { get; set; }
        public int ActionParam1 { get; set; }
        public int ActionParam2 { get; set; }
        public int ActionParam3 { get; set; }
        public int ActionParam4 { get; set; }
        public int ActionParam5 { get; set; }
        public int ActionParam6 { get; set; }
        public byte TargetType { get; set; }
        public int TargetParam1 { get; set; }
        public int TargetParam2 { get; set; }
        public int TargetParam3 { get; set; }
        public float TargetX { get; set; }
        public float TargetY { get; set; }
        public float TargetZ { get; set; }
        public float TargetO { get; set; }
        public string Comment { get; set; }
    }
}
