using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Save_Seas.Models
{
    public class ContactForm
    {
        [Key]
        [Column("FirstName")] 
        public string firstname { get; set; }

        [Required]
        [Column("LastName")]
        public string lastname { get; set; }

        [Required]
        [EmailAddress]
        [Column("Email")]
        public string email { get; set; }

        [Required]
        [Column("Phone")]
        public string phone { get; set; }

        [Required]
        [Column("Message")]
        public string message { get; set; }
    }
}
