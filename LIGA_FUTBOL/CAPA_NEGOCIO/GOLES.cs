using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class GOLES
    {
        private string TableName = "GOLES";
        public int ID_GOL { get; set; }
        public int ID_TORNEO { get; set; }
        public int ID_PARTIDO { get; set; }
        public int ID_CLUB_ANOTADOR { get; set; }
        public int JUGADOR_ANOTADOR { get; set; }
        public int MINUTO_ANOTACION { get; set; }

        public object Save(GOLES inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.ID_GOL == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "GOLES");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(GOLES INST)
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
