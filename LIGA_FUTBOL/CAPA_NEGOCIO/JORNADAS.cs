using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;


namespace CAPA_NEGOCIO
{
    public class JORNADAS
    {
        private string TableName = "JORNADAS";
        public int ID_JORNADA { get; set; }
        public int ID_TORNEO { get; set; }
        public int NUMERO_JORNADA { get; set; }

        public object Save(JORNADAS inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.ID_JORNADA == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "JORNADAS");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(JORNADAS INST)
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
