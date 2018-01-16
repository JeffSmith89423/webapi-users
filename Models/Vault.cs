using System;

namespace Keepr.Models
{
    public class Vault
    {
         public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public string UserId { get; set; }

    }
}
