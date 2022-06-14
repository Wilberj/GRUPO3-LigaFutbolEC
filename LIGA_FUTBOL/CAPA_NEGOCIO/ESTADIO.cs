using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class ESTADIO
    {
        private string TableName = "ESTADIO";
        public int ID_ESTADIO { get; set; }
        public string NOMBRE_ESTADIO { get; set; }

        public object Save(ESTADIO inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.ID_ESTADIO == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "ESTADIO");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(ESTADIO INST)
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
