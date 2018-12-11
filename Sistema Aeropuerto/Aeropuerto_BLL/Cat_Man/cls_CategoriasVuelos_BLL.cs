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
   public class cls_CategoriasVuelos_BLL
    {
        public void Listar(ref cls_CategoriasVuelos_DAL OBJ_CategoriasVuelos_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Listar_CategoriaVuelos";
                OBJ_DataBase_DAL.SNombreTabla = "CategoriasVuelos";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_CategoriasVuelos_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_CategoriasVuelos_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_CategoriasVuelos_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_CategoriasVuelos_DAL.SError = Error.Message.ToString();
            }
        }

        public void Filtrar(ref cls_CategoriasVuelos_DAL OBJ_CategoriasVuelos_DAL, string sFiltro)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_CategoriaVuelos";
                OBJ_DataBase_DAL.SNombreTabla = "CategoriasVuelos";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltro);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_CategoriasVuelos_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_CategoriasVuelos_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_CategoriasVuelos_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_CategoriasVuelos_DAL.SError = Error.Message.ToString();
            }
        }

        public void Eliminar(ref cls_CategoriasVuelos_DAL OBJ_CategoriasVuelos_DAL, string sDato)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_CategoriaVuelos";
                OBJ_DataBase_DAL.SNombreTabla = "CategoriasVuelos";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdCategoria", "1", sDato);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_CategoriasVuelos_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_CategoriasVuelos_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_CategoriasVuelos_DAL.SError = Error.Message.ToString();
            }
        }

        public void Modificar(ref cls_CategoriasVuelos_DAL OBJ_CategoriasVuelos_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_CategoriasVuelos";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);

                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdCategoria", "1", OBJ_CategoriasVuelos_DAL.CIdCategoria);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@DescCategoria", "2", OBJ_CategoriasVuelos_DAL.SDescCategoria);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_CategoriasVuelos_DAL.CIdEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_CategoriasVuelos_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_CategoriasVuelos_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_CategoriasVuelos_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_CategoriasVuelos_DAL.SError = Error.Message.ToString();
            }
        }

        public void Insertar(ref cls_CategoriasVuelos_DAL OBJ_CategoriasVuelos_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_CategoriaVuelos";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);

                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@DescCategoria", "2", OBJ_CategoriasVuelos_DAL.SDescCategoria);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_CategoriasVuelos_DAL);

                OBJ_DataBase_BLL.Execute_Scalar(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_CategoriasVuelos_DAL.SError = string.Empty;
                    OBJ_CategoriasVuelos_DAL.CAccion = 'U';
                    OBJ_CategoriasVuelos_DAL.CIdCategoria = Convert.ToInt32(OBJ_DataBase_DAL.SScalarValue);
                }
                else
                {
                    OBJ_CategoriasVuelos_DAL.SError = OBJ_DataBase_DAL.SError;
                    OBJ_CategoriasVuelos_DAL.CAccion = 'I';
                }

            }
            catch (Exception Error)
            {
                OBJ_CategoriasVuelos_DAL.SError = Error.Message.ToString();
            }
        }

    }
}
