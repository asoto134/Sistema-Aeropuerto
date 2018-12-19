using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeropuerto_DAL.Cat_Man;
using Aeropuerto_BLL.BD;
using Aeropuerto_DAL.BD;

namespace Aeropuerto_BLL.Cat_Man
{
    public class cls_Paises_BLL
    {
        public void Listar(ref cls_Paises_DAL OBJ_Paises_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Listar_Paises";
                OBJ_DataBase_DAL.SNombreTabla = "Paises";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Paises_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Paises_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Paises_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Paises_DAL.SError = Error.Message.ToString();
            }
        }

        public void Filtrar(ref cls_Paises_DAL OBJ_Paises_DAL, string sFiltro)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtar_Paises";
                OBJ_DataBase_DAL.SNombreTabla = "Paises";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltro);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Paises_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Paises_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Paises_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Paises_DAL.SError = Error.Message.ToString();
            }
        }

        public void Eliminar(ref cls_Paises_DAL OBJ_Paises_DAL, string sDato)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Paises";
                OBJ_DataBase_DAL.SNombreTabla = "¨Paises";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdPais", "4", sDato);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Paises_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Paises_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Paises_DAL.SError = Error.Message.ToString();
            }
        }

        public void Modificar(ref cls_Paises_DAL OBJ_Paises_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Paises";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);

                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdPais", "1", OBJ_Paises_DAL.IIdPais);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NombrePais", "2", OBJ_Paises_DAL.SNombrePais);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@CodigoISOPais", "4", OBJ_Paises_DAL.SCodigoISOPais);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@CodigoAreaPais", "4", OBJ_Paises_DAL.SCodigoAreaPais);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Paises_DAL.CIdEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Paises_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Paises_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Paises_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Paises_DAL.SError = Error.Message.ToString();
            }
        }

        public void Insertar(ref cls_Paises_DAL OBJ_Paises_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_Pais";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);

                //
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NombrePais", "2", OBJ_Paises_DAL.SNombrePais);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@CodigoISOPais", "4", OBJ_Paises_DAL.SCodigoISOPais);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@CodigoAreaPais", "4", OBJ_Paises_DAL.SCodigoAreaPais);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Paises_DAL.CIdEstado);

                OBJ_DataBase_BLL.Execute_Scalar(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Paises_DAL.SError = string.Empty;
                    OBJ_Paises_DAL.CAccion = 'U';
                    OBJ_Paises_DAL.IIdPais = Convert.ToInt16(OBJ_DataBase_DAL.SScalarValue);
                }
                else
                {
                    OBJ_Paises_DAL.SError = OBJ_DataBase_DAL.SError;
                    OBJ_Paises_DAL.CAccion = 'I';
                }

            }
            catch (Exception Error)
            {
                OBJ_Paises_DAL.SError = Error.Message.ToString();
            }
        }
    }
}
