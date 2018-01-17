using System.ComponentModel.DataAnnotations;

namespace Keepr.Models
{
    public class Keep
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Imageurl { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public int Saves { get; set; }
        public int Viewed { get; set; }
        

    }
}
