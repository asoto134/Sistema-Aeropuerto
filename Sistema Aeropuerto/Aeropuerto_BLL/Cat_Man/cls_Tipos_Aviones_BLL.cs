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
    public class cls_Tipo_Aviones_BLL
    {

        public void Listar_Combo(ref cls_tipos_aviones_DAL OBJ_Tipo_Aviones_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_combo_Tipos_Aviones";
                OBJ_DataBase_DAL.SNombreTabla = "Tipos Aviones";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Aviones_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Tipo_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Aviones_DAL.SError = Error.Message.ToString();
            }
        }
        public void Listar(ref cls_tipos_aviones_DAL OBJ_Tipo_Aviones_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Listar_tipos_aviones";
                OBJ_DataBase_DAL.SNombreTabla = "Tipos Aviones";

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Aviones_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Tipo_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Aviones_DAL.SError = Error.Message.ToString();
            }
        }

        public void Filtrar(ref cls_tipos_aviones_DAL OBJ_Tipo_Aviones_DAL, string sFiltro)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_Aerolineas";
                OBJ_DataBase_DAL.SNombreTabla = "Tipos Aviones";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@FILTRO", "2", sFiltro);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Aviones_DAL.OBJ_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    OBJ_Tipo_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Aviones_DAL.SError = Error.Message.ToString();
            }
        }

        public void Eliminar(ref cls_tipos_aviones_DAL OBJ_Tipo_Aviones_DAL, string sDato)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Aerolineas";
                OBJ_DataBase_DAL.SNombreTabla = "Tipos Aviones";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@ELIMINAR", "2", sDato);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Aviones_DAL.SError = Error.Message.ToString();
            }
        }

        public void Modificar(ref cls_tipos_aviones_DAL OBJ_Tipo_Aviones_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Aerolineas";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);

                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdTipoAvion", "2", OBJ_Tipo_Aviones_DAL.SIdTipoAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NombreTipoAvion", "2", OBJ_Tipo_Aviones_DAL.SNombreAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@DescTipoAvion", "2", OBJ_Tipo_Aviones_DAL.SDescTipoAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@CapacidadPasajeros", "1", OBJ_Tipo_Aviones_DAL.ICapacidadPasajeros);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@CapacidadPeso", "6", OBJ_Tipo_Aviones_DAL.DCapacidad_peso);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Tipo_Aviones_DAL.CIdEstado);

                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Tipo_Aviones_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Aviones_DAL.SError = Error.Message.ToString();
            }
        }

        public void Insertar(ref cls_tipos_aviones_DAL OBJ_Tipo_Aviones_DAL)
        {
            try
            {
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_Aerolineas";

                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);

                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdTipoAvion", "2", OBJ_Tipo_Aviones_DAL.SIdTipoAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NombreTipoAvion", "2", OBJ_Tipo_Aviones_DAL.SNombreAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@DescTipoAvion", "2", OBJ_Tipo_Aviones_DAL.SDescTipoAvion);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@CapacidadPasajeros", "1", OBJ_Tipo_Aviones_DAL.ICapacidadPasajeros);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@CapacidadPeso", "6", OBJ_Tipo_Aviones_DAL.DCapacidad_peso);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", OBJ_Tipo_Aviones_DAL.CIdEstado);


                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    OBJ_Tipo_Aviones_DAL.SError = string.Empty;
                }
                else
                {
                    OBJ_Tipo_Aviones_DAL.SError = OBJ_DataBase_DAL.SError;
                }

                OBJ_Tipo_Aviones_DAL.CAccion = 'U';

            }
            catch (Exception Error)
            {
                OBJ_Tipo_Aviones_DAL.SError = Error.Message.ToString();
            }
        }
    }
}
