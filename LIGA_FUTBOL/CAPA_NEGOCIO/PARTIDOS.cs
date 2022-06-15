using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
    public class PARTIDOS
    {
        private string TableName = "PARTIDOS";
        public int ID_PARTIDOS { get; set; }
        public int ID_JORNADA { get; set; }
        public int ID_CLUB_VISITANTE { get; set; }
        public int ID_CLUB_LOCAL { get; set; }
        public int ID_ESTADIO { get; set; }
        public bool ESTADO_PARTIDO { get; set; }
        public int GOLES_VISITANTE { get; set; }
        public int GOLES_LOCAL { get; set; }
        public DateTime FECHA { get; set; }
        public string HORA_INICIO { get; set; }
        public string HORA_FINAL { get; set; }
        public string RESULTADO_PARTIDO { get; set; }

        public object Save(PARTIDOS inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.ID_PARTIDOS == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "PARTIDOS");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
        public Object Get(PARTIDOS INST)
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
