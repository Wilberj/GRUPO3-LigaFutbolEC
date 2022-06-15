using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class LISTA_CLUBES_EN_TORNEO
    {
        private string TableName = "LISTA_CLUBES_EN_TORNEO";
        public int  ID_CLUB { get; set; }
        public int ID_TORNEO { get; set; }

        public object Save(LISTA_CLUBES_EN_TORNEO inst)
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
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "LISTA_CLUBES_EN_TORNEO");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(LISTA_CLUBES_EN_TORNEO INST)
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
