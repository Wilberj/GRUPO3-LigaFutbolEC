using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Newtonsoft.Json; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CAPA_NEGOCIO;
using CAPA_DATOS; 

namespace LIGA_FUTBOL.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClubesController : ControllerBase
    {
        [HttpPost]

        public Object TakeClubesDatos()
        {
            List<Object> response = new List<Object>(); 
            CLUBES IC = new CLUBES();
            response.Add(IC.Get(IC));
            ESTADIO ES = new ESTADIO();
            response.Add(ES.Get(ES)); 

            return response; 
        }

        [HttpPost]

        public Object SaveClub (Object ObjectInst)
        {
            CLUBES Inst = JsonConvert.DeserializeObject<CLUBES>(ObjectInst.ToString());
            Inst.Save(Inst); 
            return true; 
        }
    }
}
