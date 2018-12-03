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
    public class cls_Estados_BLL
    {
        public void Listar(ref cls_Estados_DAL OBJ_Estados_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Listar_Estados";
                OBJ_DataBase_DAL.SNombreTabla = "Estados";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Estados_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Estados_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Estados_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Estados_DAL.SError = Error.Message.ToString();
            }
        }

        public void Filtrar(ref cls_Estados_DAL OBJ_Estados_DAL, string sFiltro)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_Estados";
                OBJ_DataBase_DAL.SNombreTabla = "Estados";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltro);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Estados_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Estados_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Estados_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Estados_DAL.SError = Error.Message.ToString();
            }
        }

        public void Eliminar(ref cls_Estados_DAL OBJ_Estados_DAL, string sDato)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Estados";
                OBJ_DataBase_DAL.SNombreTabla = "Estados";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IDEstado", "4", sDato);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Estados_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Estados_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Estados_DAL.SError = Error.Message.ToString();
            }
        }

        public void Modificar(ref cls_Estados_DAL OBJ_Estados_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Estados";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IDEstado", "4", OBJ_Estados_DAL.CIDEstado);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Descripcion", "2", OBJ_Estados_DAL.SDescripcion);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Estados_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Estados_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Estados_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Estados_DAL.SError = Error.Message.ToString();
            }
        }

        public void Insertar(ref cls_Estados_DAL OBJ_Estados_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_Estados";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IDEstado", "4", OBJ_Estados_DAL.CIDEstado);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Descripcion", "2", OBJ_Estados_DAL.SDescripcion);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Estados_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Estados_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Estados_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Estados_DAL.SError = Error.Message.ToString();
            }
        }
    }
}
