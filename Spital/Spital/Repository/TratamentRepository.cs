using Spital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spital.Repository
{
    public class TratamentRepository
    {
        public void AddTratament(Spital.Models.Tratament tratament)
        {
            using (SpitalContext db = new SpitalContext())
            {
                db.Trataments.Add(tratament);
                db.SaveChanges();
            }
        }
    }
}