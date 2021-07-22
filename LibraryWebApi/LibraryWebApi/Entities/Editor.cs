using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWebApi.Entities
{
    public class Editor
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(3)]
        public int Year { get; set; }

        [MaxLength(2500)]
        public string Description { get; set; }

        public bool? Deleted { get; set; }
    }
}
