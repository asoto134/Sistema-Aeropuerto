using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeropuerto_DAL.BD;
using Aeropuerto_BLL.BD;
using Aeropuerto_DAL.Cat_Man;

namespace Aeropuerto_BLL.Cat_Man
{
    public class cls_Destinos_BLL
    {
        public void ListarDestinos(ref cls_Destinos_DAL Obj_Destinos_DAL)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL Obj_DB_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL Obj_DB_DAL = new cls_DataBase_DAL();

                //Llamar Nombre sp y nombre tabla
                Obj_DB_DAL.SSP_Nombre = "sp_Listar_Destinos";
                Obj_DB_DAL.SNombreTabla = "Destinos";

                Obj_DB_BLL.Execute_DataAdapter(ref Obj_DB_DAL);

                //Llamar Msj de Error
                if (Obj_DB_DAL.SError == string.Empty)
                {
                    Obj_Destinos_DAL.Obj_DataTable = Obj_DB_DAL.OBJ_DataSet.Tables[0];
                    Obj_Destinos_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Destinos_DAL.sMsjError = Obj_DB_DAL.SError;
                }
            }
            catch (Exception ex)
            {

                Obj_Destinos_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void FiltrarDestinos(ref cls_Destinos_DAL Obj_Destinos_DAL, string sFiltrar)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                //Llamar Nombre sp y nombre tabla
                OBJ_DataBase_DAL.SSP_Nombre = "sp_Filtrar_Destinos";
                OBJ_DataBase_DAL.SNombreTabla = "Destinos";

                //Crear parametro
                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltrar);

                OBJ_DataBase_BLL.Execute_DataAdapter(ref OBJ_DataBase_DAL);

                //Llamar Msj de Error
                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    Obj_Destinos_DAL.Obj_DataTable = OBJ_DataBase_DAL.OBJ_DataSet.Tables[0];
                    Obj_Destinos_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Destinos_DAL.sMsjError = OBJ_DataBase_DAL.SError;
                }

            }
            catch (Exception ex)
            {

                Obj_Destinos_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void EliminarDestinos(ref cls_Destinos_DAL Obj_Destinos_DAL, string sDatos)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                //Llamar  los procedimientos de sp y nombre de la tabla
                OBJ_DataBase_DAL.SSP_Nombre = "sp_Eliminar_Destinos";
                OBJ_DataBase_DAL.SNombreTabla = "Destinos";

                //Crear los parametros para eliminar con la primary key
                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdDestino", "2", sDatos);

                //Llamada del comando para eliminar en DB
                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    Obj_Destinos_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Destinos_DAL.sMsjError = OBJ_DataBase_DAL.SError;
                }
            }
            catch (Exception ex)
            {

                Obj_Destinos_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void ModificarDestinos(ref cls_Destinos_DAL Obj_Destinos_DAL)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                //solo se crea el nombre del sp
                OBJ_DataBase_DAL.SSP_Nombre = "sp_Modificar_Destinos";

                //se crean los parmatros a modificar
                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdDestino", "2", Obj_Destinos_DAL.cIdDestino);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAerolinea", "1", Obj_Destinos_DAL.cIdAerolinea);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NomDestino", "2", Obj_Destinos_DAL.sNombreDestino);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdPaisSalida", "2", Obj_Destinos_DAL.cPaisEntrada);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdPaisLlegada", "2", Obj_Destinos_DAL.cPaisSalida);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_Destinos_DAL.cIdEstado);

                //comadno para para modificar del DB.DAL
                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    Obj_Destinos_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Destinos_DAL.sMsjError = OBJ_DataBase_DAL.SError;
                }

                Obj_Destinos_DAL.cAccion = 'U';

            }
            catch (Exception ex)
            {

                Obj_Destinos_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void InsertarDestinos(ref cls_Destinos_DAL Obj_Destinos_DAL)
        {
            try
            {
                //Instanciar Databases
                cls_DataBase_BLL OBJ_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL OBJ_DataBase_DAL = new cls_DataBase_DAL();

                //Llamar nombre del sp
                OBJ_DataBase_DAL.SSP_Nombre = "sp_Insertar_Destinos";

                //Creacion de parametros para crear nuevo cliente
                OBJ_DataBase_BLL.Crear_Parametros(ref OBJ_DataBase_DAL);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdDestino", "2", Obj_Destinos_DAL.cIdDestino);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdAerolinea", "1", Obj_Destinos_DAL.cIdAerolinea);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@NomDestino", "2", Obj_Destinos_DAL.sNombreDestino);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdPaisSalida", "2", Obj_Destinos_DAL.cPaisEntrada);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdPaisLlegada", "2", Obj_Destinos_DAL.cPaisSalida);
                OBJ_DataBase_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_Destinos_DAL.cIdEstado);


                //Ejecutar comando para ingresar nuevo del DB.BLL
                OBJ_DataBase_BLL.Execute_NonQuery(ref OBJ_DataBase_DAL);

                if (OBJ_DataBase_DAL.SError == string.Empty)
                {
                    Obj_Destinos_DAL.sMsjError = string.Empty;
                    Obj_Destinos_DAL.cAccion = 'U';

                }
                else
                {
                    Obj_Destinos_DAL.sMsjError = OBJ_DataBase_DAL.SError;
                    Obj_Destinos_DAL.cAccion = 'I';
                }
            }
            catch (Exception ex)
            {

                Obj_Destinos_DAL.sMsjError = ex.Message.ToString();
            }
        }

    }
}
