using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace TestProject.Contracts.Entities
{
    public class BaseEntity
    {
        protected BaseEntity()
        { }

        public const string Username = "Zrinko";

        [Display(Name = "Created by")]
        public string CreatedBy { get; set; } = Username;


        [Display(Name = "Date created")]
        public DateTime CreatedDateUtc { get; set; } = DateTime.Now;


        [Display(Name = "Modified by")]
        public string LastModifiedBy { get; set; } = Username;


        [Display(Name = "Date modified")]
        public DateTime LastModifiedDateUtc { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
    }
}
