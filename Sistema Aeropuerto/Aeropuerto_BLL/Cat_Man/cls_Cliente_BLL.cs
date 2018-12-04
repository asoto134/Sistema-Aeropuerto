using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeropuerto_BLL.BD;
using Aeropuerto_DAL.BD;
using Aeropuerto_DAL.Cat_Man;

namespace Aeropuerto_BLL.Cat_Man
{
    public class cls_Cliente_BLL
    {
        public void ListarCliente(ref cls_Cliente_DAL Obj_CLiente_DAL)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL Obj_DB_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL Obj_DB_DAL = new cls_DataBase_DAL();

                //Llamar Nombre sp y nombre tabla
                Obj_DB_DAL.SSP_Nombre = "sp_Listar_CLiente";
                Obj_DB_DAL.SNombreTabla = "Cliente";

                Obj_DB_BLL.Execute_DataAdapter(ref Obj_DB_DAL);

                //Llamar Msj de Error
                if (Obj_DB_DAL.SError == string.Empty)
                {
                    Obj_CLiente_DAL.Obj_DataTable = Obj_DB_DAL.OBJ_DataSet.Tables[0];
                    Obj_CLiente_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_CLiente_DAL.sMsjError = Obj_DB_DAL.SError;
                }
            }
            catch (Exception ex)
            {

                Obj_CLiente_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void FiltrarCliente(ref cls_Cliente_DAL Obj_CLiente_DAL, string sFiltrar)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                //Llamar Nombre sp y nombre tabla
                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_Cliente";
                OBJ_DataBase_DAL.SNombreTabla = "Cliente";

                //Crear parametro
                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltrar);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                //Llamar Msj de Error
                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    Obj_CLiente_DAL.Obj_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    Obj_CLiente_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_CLiente_DAL.sMsjError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception ex)
            {

                Obj_CLiente_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void EliminarCliente(ref cls_Cliente_DAL Obj_CLiente_DAL, string sDatos)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                //Llamar  los procedimientos de sp y nombre de la tabla
                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Cliente";
                OBJ_DataBase_DAL.SNombreTabla = "Cliente";

                //Crear los parametros para eliminar con la primary key
                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdCliente", "2", sDatos);

                //Llamada del comando para eliminar en DB
                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    Obj_CLiente_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_CLiente_DAL.sMsjError = OBJ_DataBase_DAL.SError;
                }
            }
            catch (Exception ex)
            {

                Obj_CLiente_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void ModificarCliente(ref cls_Cliente_DAL Obj_CLiente_DAL)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                //solo se crea el nombre del sp
                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Cliente";

                //se crean los parmatros a modificar
                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdCliente", "2", Obj_CLiente_DAL.cIdCliente);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Cedula", "2", Obj_CLiente_DAL.sCedula);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NombreCliente", "2", Obj_CLiente_DAL.sNombreCliente);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@ApellidoCliente", "2", Obj_CLiente_DAL.sApellidoCliente);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Telefono", "2", Obj_CLiente_DAL.sTel);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdTipoCliente", "2", Obj_CLiente_DAL.cIdTipoCliente);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_CLiente_DAL.cIdEstado);

                //comadno para para modificar del DB.DAL
                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    Obj_CLiente_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_CLiente_DAL.sMsjError = OBJ_DataBase_DAL.SError;
                }

                Obj_CLiente_DAL.cAccion = 'U';

            }
            catch (Exception ex)
            {

                Obj_CLiente_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void InsertarCliente(ref cls_Cliente_DAL Obj_CLiente_DAL)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                //Llamar nombre del sp
                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_CLiente";

                //Creacion de parametros para crear nuevo cliente
                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdCliente", "2", Obj_CLiente_DAL.cIdCliente);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Cedula", "2", Obj_CLiente_DAL.sCedula);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NombreCliente", "2", Obj_CLiente_DAL.sNombreCliente);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@ApellidoCliente", "2", Obj_CLiente_DAL.sApellidoCliente);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Telefono", "2", Obj_CLiente_DAL.sTel);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdTipoCliente", "2", Obj_CLiente_DAL.cIdTipoCliente);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_CLiente_DAL.cIdEstado);


                //Ejecutar comando para ingresar nuevo del DB.BLL
                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    Obj_CLiente_DAL.sMsjError = string.Empty;
                    Obj_CLiente_DAL.cAccion = 'U';

                }
                else
                {
                    Obj_CLiente_DAL.sMsjError = OBJ_DataBase_DAL.SError;
                    Obj_CLiente_DAL.cAccion = 'I';
                }
            }
            catch (Exception ex)
            {

                Obj_CLiente_DAL.sMsjError = ex.Message.ToString();
            }
        }
    }
}
