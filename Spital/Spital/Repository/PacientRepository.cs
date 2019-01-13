using Spital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spital.Repository
{
    public class PacientRepository
    {
        public void AddPacient(Spital.Models.Pacient pacient)
        {
            using (SpitalContext db = new SpitalContext())
            {
                db.Pacients.Add(pacient);
                db.SaveChanges();
            }
        }
    }
}