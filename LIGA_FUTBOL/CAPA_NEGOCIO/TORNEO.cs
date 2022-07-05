using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
    public class TORNEO
    {
        public string TableName = "TORNEO";
        public int ID_TORNEO { get; set; }
        public string NOMBRE_TORNEO { get; set; }
        public DateTime FECHA_INICIO { get; set; }
        public DateTime FECHA_FINAL { get; set; }
        public int NUMERO_DE_JORNADAS { get; set; }

        public Object Save(TORNEO INST)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (INST.ID_TORNEO == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, INST);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, INST, "ID_TORNEO");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(TORNEO INST)
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
