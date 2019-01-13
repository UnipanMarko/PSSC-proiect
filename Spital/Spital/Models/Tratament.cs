using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Spital.Models
{
    public class Tratament
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdTratament { get; set; }
        [Display(Name = "Tratament")]
        [RelationScaffolding.RelationDisplay]
        public string Nume { get; set; }
    }
}