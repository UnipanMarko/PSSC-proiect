using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Spital.Models
{
    public class Pacient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdPacient { get; set; }

        [Display(Name = "Pacient")]
        [RelationScaffolding.RelationDisplay]
        public string Nume { get; set; }

        public int Buget { get; set; }

        [RelationScaffolding.RelationDisplay]
        [RelationScaffolding.Relation]

        public virtual Doctor Doctor { get; set; }
        [RelationScaffolding.RelationDisplay]
        [RelationScaffolding.Relation]
        public virtual Tratament Tratament { get; set; }
    }
}