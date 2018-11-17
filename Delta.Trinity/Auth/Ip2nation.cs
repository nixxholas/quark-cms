using System.ComponentModel.DataAnnotations;

namespace Delta.Trinity.Auth
{
    public class Ip2nation
    {
        [Key]
        public int Ip { get; set; }
        
        public string Country { get; set; }
    }
}