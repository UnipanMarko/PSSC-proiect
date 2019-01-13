using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Spital.Models
{
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdDoctor { get; set; }
        public string Nume { get; set; }
        [RelationScaffolding.Relation]
        public virtual ICollection<Pacient> Pacients { get; set; }
        [RelationScaffolding.Relation]
        public virtual ICollection<Tratament> Trataments { get; set; }
    }
}