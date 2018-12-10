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
    public class cls_Tipo_Empleados_BLL
    {
        public void Listar(ref cls_Tipo_Empleados_DAL OBJ_Tipo_Empleados_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Listar_Tipo_Empleado";
                OBJ_DataBase_DAL.SNombreTabla = "Tipo Empleado";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Empleados_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Tipo_Empleados_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Empleados_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Empleados_DAL.SError = Error.Message.ToString();
            }
        }

        public void Filtrar(ref cls_Tipo_Empleados_DAL OBJ_Tipo_Empleados_DAL, string sFiltro)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_Tipo_Empleado";
                OBJ_DataBase_DAL.SNombreTabla = "Tipo Empleado";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltro);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Empleados_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Tipo_Empleados_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Empleados_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Empleados_DAL.SError = Error.Message.ToString();
            }
        }

        public void Eliminar(ref cls_Tipo_Empleados_DAL OBJ_Tipo_Empleados_DAL, string sDato)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Tipo_Empleados";
                OBJ_DataBase_DAL.SNombreTabla = "Eliminar Tipo Empleados ";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdTipoEmpleado", "4", sDato);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Empleados_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Empleados_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Empleados_DAL.SError = Error.Message.ToString();
            }
        }

        public void Modificar(ref cls_Tipo_Empleados_DAL OBJ_Tipo_Empleados_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Tipo_Empleado";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);

                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdTipoEmpleado", "1", OBJ_Tipo_Empleados_DAL.IIdTipoEmpleado);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@DescTipo", "2", OBJ_Tipo_Empleados_DAL.SDescTipo);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Tipo_Empleados_DAL.CIdEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Empleados_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Empleados_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Tipo_Empleados_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Empleados_DAL.SError = Error.Message.ToString();
            }
        }

        public void Insertar(ref cls_Tipo_Empleados_DAL OBJ_Tipo_Empleados_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Tipo_Empleado";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@DescTipo", "2", OBJ_Tipo_Empleados_DAL.SDescTipo);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Tipo_Empleados_DAL);

                OBJ_DataBase_BLL.Execute_Scalar(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Empleados_DAL.SError = string.Empty;
                    OBJ_Tipo_Empleados_DAL.CAccion = 'U';
                    OBJ_Tipo_Empleados_DAL.IIdTipoEmpleado = Convert.ToInt16(OBJ_DataBase_DAL.SScalarValue);
                }
                else
                {
                    OBJ_Tipo_Empleados_DAL.SError = OBJ_DataBase_DAL.SError;
                    OBJ_Tipo_Empleados_DAL.CAccion = 'I';
                }

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Empleados_DAL.SError = Error.Message.ToString();
            }
        }
    }

}

