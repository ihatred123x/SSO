﻿using SSO.IRepository.Models.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSO.Repository.Contexts.Models.Configuration
{
    [Table("ApiProperty")]
    public class ApiProperty : ApiResourceBase, IApiProperty
    {
        [Required]
        [MaxLength(250)]
        public string Key { get; set; }

        [Required]
        [MaxLength(2000)]
        public string Value { get; set; }

    }
}
