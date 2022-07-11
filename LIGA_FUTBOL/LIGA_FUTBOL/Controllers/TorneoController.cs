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
    public class TorneoController : ControllerBase
    {
        
        [HttpPost]
        public Object SaveTorneo(Object Objectinst)
        {
            TORNEO Inst = JsonConvert.DeserializeObject<TORNEO>(Objectinst.ToString());
            Inst.Save(Inst);
            return true;
        }



        [HttpPost]

        public Object TakeTorneoDatos()
        {
            List<Object> response = new List<Object>();
            TORNEO TO = new TORNEO();
            response.Add(TO.Get(TO));
            CLUBES CL = new CLUBES();
            response.Add(CL.Get(CL));

            return response;
        }

        //public object GetTorneo()
        //{
        //    TORNEO Ins = new TORNEO();
        //    return Ins.Get(Ins);
        //}
        
    }
}
