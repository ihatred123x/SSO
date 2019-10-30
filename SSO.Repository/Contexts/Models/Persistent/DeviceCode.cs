using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Persistent
{
    [Table("DeviceCode")]
    public class DeviceCode
    {
        [Key]
        [Required]
        [MaxLength(200)]
        public string Code { get; set; }

        [Required]
        [MaxLength(200)]
        public string UserCode { get; set; }
        [Required]
        [MaxLength(200)]
        public string SubjectId { get; set; }
        [Required]
        [MaxLength(200)]
        public string ClientId { get; set; }
        [Required]
        public DateTime CreationTime { get; set; }
        [Required]
        public DateTime Expiration { get; set; }
        [Required]
        public string Data { get; set; }
    }
}
