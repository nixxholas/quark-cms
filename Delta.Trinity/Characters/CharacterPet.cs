namespace Delta.Trinity.Characters
{
    public partial class CharacterPet
    {
        public int Id { get; set; }
        public int Entry { get; set; }
        public long Owner { get; set; }
        public int? Modelid { get; set; }
        public int CreatedBySpell { get; set; }
        public byte PetType { get; set; }
        public short Level { get; set; }
        public int Exp { get; set; }
        public byte Reactstate { get; set; }
        public string Name { get; set; }
        public byte Renamed { get; set; }
        public byte Slot { get; set; }
        public int Curhealth { get; set; }
        public int Curmana { get; set; }
        public int Savetime { get; set; }
        public string Abdata { get; set; }
        public short Specialization { get; set; }
    }
}
