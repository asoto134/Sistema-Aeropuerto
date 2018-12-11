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
    public class cls_Aerolineas_BLL
    {
        public void Listar(ref cls_Aerolineas_DAL OBJ_Aerolineas_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Listar_Aerolineas";
                OBJ_DataBase_DAL.SNombreTabla = "Aerolineas";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aerolineas_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Aerolineas_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Aerolineas_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Aerolineas_DAL.SError = Error.Message.ToString();
            }
        }

        public void Filtrar(ref cls_Aerolineas_DAL OBJ_Aerolineas_DAL, string sFiltro)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_Aerolineas";
                OBJ_DataBase_DAL.SNombreTabla = "Aerolineas";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltro);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aerolineas_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Aerolineas_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Aerolineas_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Aerolineas_DAL.SError = Error.Message.ToString();
            }
        }

        public void Eliminar(ref cls_Aerolineas_DAL OBJ_Aerolineas_DAL, string sDato)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Aerolineas";
                OBJ_DataBase_DAL.SNombreTabla = "Aerolineas";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@ELIMINAR", "1", sDato);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aerolineas_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Aerolineas_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Aerolineas_DAL.SError = Error.Message.ToString();
            }
        }

        public void Modificar(ref cls_Aerolineas_DAL OBJ_Aerolineas_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Aerolineas";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);

                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAerolinea", "1", OBJ_Aerolineas_DAL.CIdAerolinea);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NombreAerolinea", "2", OBJ_Aerolineas_DAL.SNombreAerolinea);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Aerolineas_DAL.CIdEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aerolineas_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Aerolineas_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Aerolineas_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Aerolineas_DAL.SError = Error.Message.ToString();
            }
        }

        public void Insertar(ref cls_Aerolineas_DAL OBJ_Aerolineas_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_Aerolineas";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NombreAerolinea", "2", OBJ_Aerolineas_DAL.SNombreAerolinea);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Aerolineas_DAL);                

                OBJ_DataBase_BLL.Execute_Scalar(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aerolineas_DAL.SError = string.Empty;
                    OBJ_Aerolineas_DAL.CAccion = 'U';
                    OBJ_Aerolineas_DAL.CIdAerolinea = Convert.ToInt32(OBJ_DataBase_DAL.SScalarValue);
                }
                else
                {
                    OBJ_Aerolineas_DAL.SError = OBJ_DataBase_DAL.SError;
                    OBJ_Aerolineas_DAL.CAccion = 'I';                    
                }                

            }
            catch (Exception Error)
            {
                OBJ_Aerolineas_DAL.SError = Error.Message.ToString();
            }
        }
    }
}
