using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class CLUBES
    {
        private string TableName = "CLUBES"; 

        public int idClub { get; set; }
        
        public int idEstadio { get; set; }

        public string nombreClub { get; set; }


        public object Save(CLUBES inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.idClub== -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "CLUBES");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(CLUBES INST)
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
