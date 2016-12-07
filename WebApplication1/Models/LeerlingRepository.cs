using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LeerlingRepository : ILeerlingRepository<Leerling>
    {
        
         public Leerling createLeerling(Leerling leerling)
        {
            throw new NotImplementedException();
        }

        
        public bool deleteLeerling(string Id)
        {
            throw new NotImplementedException();
        }

        
        public IEnumerable<Leerling> getAllLeerlingen()
        {
            throw new NotImplementedException();
        }

        public Leerling readLeerling(string id)
        {
            throw new NotImplementedException();
        }

        public Leerling UpdateLeerling(string id, Leerling leerling)
        {
            throw new NotImplementedException();
        }
    }
}