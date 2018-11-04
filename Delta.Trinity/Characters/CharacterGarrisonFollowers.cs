using System.Collections.Generic;

namespace Delta.Trinity.Characters
{
    public partial class CharacterGarrisonFollowers
    {
        public CharacterGarrisonFollowers()
        {
            CharacterGarrisonFollowerAbilities = new HashSet<CharacterGarrisonFollowerAbilities>();
        }

        public long DbId { get; set; }
        public long Guid { get; set; }
        public int FollowerId { get; set; }
        public int Quality { get; set; }
        public int Level { get; set; }
        public int ItemLevelWeapon { get; set; }
        public int ItemLevelArmor { get; set; }
        public int Xp { get; set; }
        public int CurrentBuilding { get; set; }
        public int CurrentMission { get; set; }
        public int Status { get; set; }

        public virtual Characters Gu { get; set; }
        public virtual ICollection<CharacterGarrisonFollowerAbilities> CharacterGarrisonFollowerAbilities { get; set; }
    }
}
