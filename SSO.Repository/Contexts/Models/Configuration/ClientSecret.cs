using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ClientSecret")]
    public class ClientSecret : ClientBase
    {
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        [Required]
        [MaxLength(4000)]
        public string Value { get; set; }

        public Nullable<DateTime> Expiration { get; set; }
        [MaxLength(250)]
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime Created { get; set; }
    }
}
