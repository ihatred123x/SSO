using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ApiSecret")]
    public class ApiSecret: ApiResourceBase
    {
        [MaxLength(1000)]
        [Required]
        public string Description { get; set; }
        [MaxLength(4000)]
        [Required]
        public string Value { get; set; }
    public Nullable<DateTime> Expiration { get; set; }
        [MaxLength(250)]
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime Created { get; set; }
    }
}
