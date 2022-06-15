using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class LISTA_JUGADORES_NOMINA
    {
        private string TableName = "LISTA_JUGADORES_NOMINA";
        public int ID_CLUB { get; set; }
        public int ID_JUGADOR { get; set; }
        public int ID_TORNEO { get; set; }

        public object Save(LISTA_JUGADORES_NOMINA inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.ID_CLUB == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "LISTA_JUGADORES_NOMINA");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(LISTA_JUGADORES_NOMINA INST)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");
                return SqlADOConexion.SQLM.TakeList(TableName, INST, null);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
