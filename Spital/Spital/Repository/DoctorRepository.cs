using Spital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spital.Repository
{
    public class DoctorRepository
    {
        public void AddDoctor(Spital.Models.Doctor doctor)
        {
            using (SpitalContext db = new SpitalContext())
            {
                db.Doctors.Add(doctor);
                db.SaveChanges();
            }
        }
    }
}