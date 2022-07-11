using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;

namespace CAPA_NEGOCIO
{
    public class CLUBES
    {
        private string TableName = "CLUBES"; 

        public int ID_CLUB{ get; set; }
        
        public int ID_ESTADIO_CLUB { get; set; }

        public string NOMBRE_CLUB { get; set; }


        public object Save(CLUBES INST)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (INST.ID_CLUB== -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, INST);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, INST, "ID_CLUB");
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
