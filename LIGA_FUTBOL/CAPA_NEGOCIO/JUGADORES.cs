using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class JUGADORES
    {
        private string TableName = "JUGADORES";

        public int ID_JUGADOR { get; set; }

        public string PRIMER_NOMBRE { get; set; }
        public string SEGUNDO_NOMBRE { get; set; }
        public string PRIMER_APELLDIO { get; set; }
        public string SEGUNDO_APELLIDO { get; set; }
        public DateTime FECHA_NACIMIENTO  { get; set; }

        public string NACIONALIDAD { get; set; }

        public object Save(JUGADORES INST)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (INST.ID_JUGADOR == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, INST);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, INST, "ID_JUGADOR");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(JUGADORES INST)
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
