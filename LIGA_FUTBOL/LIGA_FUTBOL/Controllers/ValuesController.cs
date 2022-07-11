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
    public class ValuesController : ControllerBase
    {
        

        #region Estadio
        public Object SaveEstadio(Object Objectinst)
        {
            ESTADIO Inst = JsonConvert.DeserializeObject<ESTADIO>(Objectinst.ToString());
            Inst.Save(Inst);
            return true;
        }

        [HttpGet]

        public object GetEstadio()
        {
            ESTADIO Ins = new ESTADIO();
            return Ins.Get(Ins);
        }
        #endregion

        #region Jugador
        public Object SaveJugador(Object Objectinst)
        {
            JUGADORES Inst = JsonConvert.DeserializeObject<JUGADORES>(Objectinst.ToString());
            Inst.Save(Inst);
            return true;
        }

        [HttpGet]

        public object GetJugador()
        {
            JUGADORES Ins = new JUGADORES();
            return Ins.Get(Ins);
        }
        #endregion

        
    }
}
