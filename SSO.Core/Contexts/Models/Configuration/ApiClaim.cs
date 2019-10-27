using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.Core.Contexts.Models.Configuration
{
    [Table("ApiClaim")]
    public class ApiClaim: ApiResourceBase
    {
        [MaxLength(200)]
        [Required]
        public string Type { get; set; }

    }
}
