﻿using System;
using System.Collections.Generic;
using System.Text;
using CAPA_DATOS;
namespace CAPA_NEGOCIO
{
    public class TORNEO
    {
        private string TableName = "TORNEO";
        public int ID_TORNEO { get; set; }
        public string NOMBRE_TORENO { get; set; }
        public DateTime FECHA_INICIO { get; set; }
        public DateTime FECHA_FINAL { get; set; }
        public int NUMERO_DE_JORNADAS { get; set; }

        public object Save(TORNEO inst)
        {
            try
            {
                SqlADOConexion.IniciarConexion("sa", "1234");


                if (inst.ID_TORNEO == -1)
                {
                    return SqlADOConexion.SQLM.InsertObject(TableName, inst);

                }
                else
                {
                    return SqlADOConexion.SQLM.UpdateObject(TableName, inst, "JUGADORES");
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
