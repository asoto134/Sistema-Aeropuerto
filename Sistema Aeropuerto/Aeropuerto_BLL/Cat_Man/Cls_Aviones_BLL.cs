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
    public class cls_Aviones_BLL
    {

        public void Listar(ref cls_Aviones_DAL OBJ_Aviones_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Listar_Aviones";
                OBJ_DataBase_DAL.SNombreTabla = "Aviones";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aviones_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Aviones_DAL.SError = Error.Message.ToString();
            }
        }

        public void Filtrar(ref cls_Aviones_DAL OBJ_Aviones_DAL, string sFiltro)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_Aviones";
                OBJ_DataBase_DAL.SNombreTabla = "Aviones";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltro);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aviones_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Aviones_DAL.SError = Error.Message.ToString();
            }
        }

        public void Eliminar(ref cls_Aviones_DAL OBJ_Aviones_DAL, string sDato)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Aviones";
                OBJ_DataBase_DAL.SNombreTabla = "Aviones";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAvion", "2", sDato);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Aviones_DAL.SError = Error.Message.ToString();
            }
        }

        public void Modificar(ref cls_Aviones_DAL OBJ_Aviones_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Aviones";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAvion", "2", OBJ_Aviones_DAL.SIdAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NomAvion", "2", OBJ_Aviones_DAL.SNomAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@DescAvion", "2", OBJ_Aviones_DAL.SDescAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAerolinea", "1", OBJ_Aviones_DAL.CIdAerolinea);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdTipoAvion", "2", OBJ_Aviones_DAL.SIdTipoAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Aviones_DAL.CIdEstado);



                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Aviones_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Aviones_DAL.SError = Error.Message.ToString();
            }
        }

        public void Insertar(ref cls_Aviones_DAL OBJ_Aviones_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_Aviones";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAvion", "2", OBJ_Aviones_DAL.SIdAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NomAvion", "2", OBJ_Aviones_DAL.SNomAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@DescAvion", "2", OBJ_Aviones_DAL.SDescAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAerolinea", "1", OBJ_Aviones_DAL.CIdAerolinea);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdTipoAvion", "2", OBJ_Aviones_DAL.SIdTipoAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Aviones_DAL.CIdEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Aviones_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Aviones_DAL.SError = Error.Message.ToString();
            }
        }
    }
}