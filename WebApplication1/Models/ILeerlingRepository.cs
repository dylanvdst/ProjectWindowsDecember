using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public interface ILeerlingRepository<Leerling>
    {
        Leerling createLeerling(Leerling leerling);
        IEnumerable<Leerling> getAllLeerlingen();
        Leerling readLeerling(string id);
        Leerling UpdateLeerling(string id, Leerling leerling);
        Boolean deleteLeerling(String Id);

    }
}