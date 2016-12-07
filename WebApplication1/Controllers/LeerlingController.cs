using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LeerlingController : ApiController
    {
        private LeerlingRepository repository = null;
        
        public LeerlingController()
        {
            this.repository = new LeerlingRepository;
        }
        [HttpGet]
        public HttpResponseMessage Get()
        { IEnumerable<Leerling> leerlingen = this.repository.getAllLeerlingen();
            if (leerlingen != null)
            {
                return Request.CreateResponse<IEnumerable<Leerling>>(HttpStatusCode.OK, leerlingen);
            } else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpGet]
        public HttpResponseMessage Get(String id)
        { Leerling leerling = this.repository.readLeerling(id);
            if (leerling != null)
            {
                return Request.CreateResponse<Leerling>(HttpStatusCode.OK, leerling);
            } else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpPost]
        public HttpResponseMessage Post(Leerling leerling)
        { 
            if ((this.ModelState.IsValid) && (leerling != null))
            {
                Leerling newLeerling = this.repository.createLeerling(leerling);
                 if (newLeerling != null)
                {
                    var httpResponse = Request.CreateResponse<Leerling>(HttpStatusCode.Created, newLeerling);
                    string uri = Url.Link("DefaultApi", new { id = newLeerling.Id });
                    httpResponse.Headers.Location = new Uri(uri); return httpResponse;
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public HttpResponseMessage Put(String id, Leerling leerling)
        {
            if ((this.ModelState.IsValid) && (leerling != null) && (leerling.Id.Equals(id)))
            {
                Leerling aangepasteleerling = this.repository.UpdateLeerling(id, leerling);
                if (aangepasteleerling != null)
                {
                    return Request.CreateResponse<Leerling>(HttpStatusCode.OK, aangepasteleerling);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
            } return Request.CreateResponse(HttpStatusCode.BadRequest); }

        [HttpDelete]
        public HttpResponseMessage Delete(String id)
        {
            Leerling leerling = this.repository.readLeerling(id);
            if (leerling != null)
            {
                if (this.repository.deleteLeerling(id)) {
                    return Request.CreateResponse(HttpStatusCode.OK); }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }

}

