using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeropuerto_DAL.Cat_Man;
using Aeropuerto_DAL.BD;
using Aeropuerto_BLL.BD;


namespace Aeropuerto_BLL.Cat_Man
{
    public class cls_Vuelos_BLL
    {

        public void Listar(ref cls_Vuelos_DAL OBJ_Vuelos_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Listar_Vuelos";
                OBJ_DataBase_DAL.SNombreTabla = "Vuelos";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Vuelos_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Vuelos_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Vuelos_DAL.sError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Vuelos_DAL.sError = Error.Message.ToString();
            }
        }

        public void Filtrar(ref cls_Vuelos_DAL OBJ_Vuelos_DAL, string sFiltro)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_Vuelos";
                OBJ_DataBase_DAL.SNombreTabla = "Vuelos";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltro);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Vuelos_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Vuelos_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Vuelos_DAL.sError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Vuelos_DAL.sError = Error.Message.ToString();
            }
        }

        public void Eliminar(ref cls_Vuelos_DAL OBJ_Vuelos_DAL, string sDato)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Vuelos";
                OBJ_DataBase_DAL.SNombreTabla = "Vuelos";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdVuelo", "2", sDato);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Vuelos_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Vuelos_DAL.sError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Vuelos_DAL.sError = Error.Message.ToString();
            }
        }

        public void Modificar(ref cls_Vuelos_DAL OBJ_Vuelos_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Vuelos";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdVuelo", "2", OBJ_Vuelos_DAL.sIdVuelo);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdDestino", "2", OBJ_Vuelos_DAL.sIdDestino);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAerolinea", "1", OBJ_Vuelos_DAL.iIdAerolinea);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAvion", "2", OBJ_Vuelos_DAL.sIdAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@FechaHoraSalida", "7", OBJ_Vuelos_DAL.dtFechaHoraSalida);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@FechaHoraLlegada", "7", OBJ_Vuelos_DAL.dtFechaHoraLlegada);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Vuelos_DAL.cIDEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Vuelos_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Vuelos_DAL.sError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Vuelos_DAL.cAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Vuelos_DAL.sError = Error.Message.ToString();
            }
        }

        public void Insertar(ref cls_Vuelos_DAL OBJ_Vuelos_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_Vuelos";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdVuelo", "2", OBJ_Vuelos_DAL.sIdVuelo);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdDestino", "2", OBJ_Vuelos_DAL.sIdDestino);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAerolinea", "1", OBJ_Vuelos_DAL.iIdAerolinea);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAvion", "2", OBJ_Vuelos_DAL.sIdAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@FechaHoraSalida", "7", OBJ_Vuelos_DAL.dtFechaHoraSalida);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@FechaHoraLlegada", "7", OBJ_Vuelos_DAL.dtFechaHoraLlegada);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Vuelos_DAL.cIDEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Vuelos_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Vuelos_DAL.sError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Vuelos_DAL.cAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Vuelos_DAL.sError = Error.Message.ToString();
            }
        }

    }
}
