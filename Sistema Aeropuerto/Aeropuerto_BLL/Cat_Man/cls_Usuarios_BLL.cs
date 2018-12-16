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
    public class cls_Usuarios_BLL
    {
        public void Listar(ref cls_Usuarios_DAL OBJ_Usuarios_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Listar_Usuarios";
                OBJ_DataBase_DAL.SNombreTabla = "Usuarios";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Usuarios_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Usuarios_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Usuarios_DAL.sError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Usuarios_DAL.sError = Error.Message.ToString();
            }
        }

        public void Filtrar(ref cls_Usuarios_DAL OBJ_Usuarios_DAL, string sFiltro)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_Usuarios";
                OBJ_DataBase_DAL.SNombreTabla = "Usuarios";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltro);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Usuarios_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Usuarios_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Usuarios_DAL.sError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Usuarios_DAL.sError = Error.Message.ToString();
            }
        }

        public void Eliminar(ref cls_Usuarios_DAL OBJ_Usuarios_DAL, string sDato)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Usuarios";
                OBJ_DataBase_DAL.SNombreTabla = "Usuarios";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Username", "2", sDato);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Usuarios_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Usuarios_DAL.sError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Usuarios_DAL.sError = Error.Message.ToString();
            }
        }

        public void Modificar(ref cls_Usuarios_DAL OBJ_Usuarios_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Usuarios";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Username", "2", OBJ_Usuarios_DAL.sUsername);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Password", "2", OBJ_Usuarios_DAL.sPassword);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Usuarios_DAL.cIDEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Usuarios_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Usuarios_DAL.sError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Usuarios_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Usuarios_DAL.sError = Error.Message.ToString();
            }
        }

        public void Insertar(ref cls_Usuarios_DAL OBJ_Usuarios_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_Usuarios";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Username", "2", OBJ_Usuarios_DAL.sUsername);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Password", "2", OBJ_Usuarios_DAL.sPassword);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEmpleado", "2", OBJ_Usuarios_DAL.sIdEmpleado);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Usuarios_DAL.cIDEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Usuarios_DAL.sError = string.Empty;
                }
                else
                {
                    OBJ_Usuarios_DAL.sError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Usuarios_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Usuarios_DAL.sError = Error.Message.ToString();
            }
        }
    }
}
