namespace Delta.Trinity.Characters
{
    public partial class CharacterGarrisonFollowerAbilities
    {
        public long DbId { get; set; }
        public int AbilityId { get; set; }
        public byte Slot { get; set; }

        public virtual CharacterGarrisonFollowers Db { get; set; }
    }
}
