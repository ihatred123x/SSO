using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.Repository.Contexts.Models.Persistent
{
    [Table("PersistentGrant")]
    public class PersistentGrant
    {
        [Key]
        [Required]
        [MaxLength(200)]
        public string Key { get; set; }
        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
        [MaxLength(200)]
        public string SubjectId { get; set; }
        [MaxLength(200)]
        public string ClientId { get; set; }
        public DateTime CreationTime { get; set; }
        public Nullable<DateTime> Expiration { get; set; }
        public string Data { get; set; }
    }
}
