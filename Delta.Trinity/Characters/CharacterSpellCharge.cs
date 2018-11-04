namespace Delta.Trinity.Characters
{
    public class CharacterSpellCharge
    {
        public long Guid { get; set; }
        
        public int CategoryId { get; set; }
        
        public int RechargeStart { get; set; }
        
        public int RechargeEnd { get; set; }
    }
}