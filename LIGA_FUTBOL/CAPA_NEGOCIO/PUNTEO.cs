using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class PUNTEO
    {
        private string TableName = "PUNTEO";
        public int ID_PUNTEO { get; set; }
        public int ID_TORNEO { get; set; }
        public int ID_PARTIDO { get; set; }
        public int ID_CLUB { get; set; }
        public int PUNTOS { get; set; }

        public object Save(PUNTEO inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.ID_PUNTEO == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "PUNTEO");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(PUNTEO  INST)
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
