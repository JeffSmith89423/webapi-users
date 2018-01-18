using System.ComponentModel.DataAnnotations;

namespace Keepr.Models
{
    public class VaultKeep
    {
         public int Id { get; set; }
        [MaxLength(255)]
        public int VaultId { get; set; }
        [MaxLength(255)]
        public int KeepId{ get; set; }
        public string UserId { get; set; }

    }
}
