using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSO.Repository.Contexts.Models.Configuration
{
    public class ClientRedirectUri: ClientBase
    {
        [Required]
        [MaxLength(2000)]
        public string RedirectUri { get; set; }
    }
}
