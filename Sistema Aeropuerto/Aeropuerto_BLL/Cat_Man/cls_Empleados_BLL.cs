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
    public class cls_Empleados_BLL
    {
        public void ListarEmpleados(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            try
            {
                //INTANCIAR LOS OBJETOS DE LA BASE DE DATOS
                cls_DataBase_BLL Obj_DataBase_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL Obj_DataBase_DAL = new cls_DataBase_DAL();

                //LLAMAR AL SQL STORED PROCEDURE CON SU NOMBRE TABLA
                Obj_DataBase_DAL.SSP_Nombre = "sp_Listar_Empleados";
                Obj_DataBase_DAL.SNombreTabla = "Empleados";

                //EJECUTAR EL METODO PARA LLAMAR A LA TABLA Y MOSTRAR
                Obj_DataBase_BLL.Execute_DataAdapter(ref Obj_DataBase_DAL);

                //DECLARACION DEL MSJ DE ERROR
                if (Obj_DataBase_DAL.SError == string.Empty)
                {
                    Obj_Empleados_DAL.Obj_DataTable = Obj_DataBase_DAL.OBJ_DataSet.Tables[0];
                    Obj_Empleados_DAL.sMsjError = string.Empty;

                }
                else
                {
                    Obj_Empleados_DAL.sMsjError = Obj_DataBase_DAL.SError;
                }

            }
            catch (Exception ex)
            {

                Obj_Empleados_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void FiltrarEmpleados(ref cls_Empleados_DAL Obj_Empleados_DAL, string sFiltrar)
        {
            try
            {
                //INTACIAR LOS OBJ DE LAS BASE DE DATOS
                cls_DataBase_DAL Obj_DB_DAL = new cls_DataBase_DAL();
                cls_DataBase_BLL Obj_DB_BLL = new cls_DataBase_BLL();

                //LLAMAR EL NOMBRE DE LA TABLA Y EL STORED PROCEDURE
                Obj_DB_DAL.SSP_Nombre = "sp_Filtrar_Empleados";
                Obj_DB_DAL.SNombreTabla = "Empleados";

                //CREAR PARAMETRO PARA EL FILTRO DE LA INFORMACION EN LA TABLA
                Obj_DB_BLL.Crear_Parametros(ref Obj_DB_DAL);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Filtro", "2", sFiltrar);

                //EJECUTR METODO DE LLAMADO DE FILTRO
                Obj_DB_BLL.Execute_DataAdapter(ref Obj_DB_DAL);

                //PRUEBA DE MSJ DE ERROR
                if (Obj_DB_DAL.SError == string.Empty)
                {
                    Obj_Empleados_DAL.Obj_DataTable = Obj_DB_DAL.OBJ_DataSet.Tables[0];
                    Obj_Empleados_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Empleados_DAL.sMsjError = Obj_DB_DAL.SError;
                }
            }
            catch (Exception ex)
            {

                Obj_Empleados_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void EliminarEmpleados(ref cls_Empleados_DAL Obj_Empleaos_DAL, string sDatos)
        {
            try
            {
                //INSTANCEAR LOS OBJETOS DE LAS BASES DE DATOS
                cls_DataBase_BLL Obj_DB_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL Obj_DB_DAL = new cls_DataBase_DAL();

                //LLAMAR EL NOMBRE DE LA TABLA A ELIMINAR Y EL STOREDE PROCEDURE
                Obj_DB_DAL.SSP_Nombre = "sp_Eliminar_Empleados";
                Obj_DB_DAL.SNombreTabla = "Empleados";

                //CREACION DEL PARAMETRO PARA LA BUSQUEDA DE LA INFORMACION A ELIMINAR
                Obj_DB_BLL.Crear_Parametros(ref Obj_DB_DAL);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@IdEmpleado", "2", sDatos);

                //EJECUCION DEL METODO PARA BUSCAR LA INFORMACION DE LA TABLA A ELIMINAR
                Obj_DB_BLL.Execute_NonQuery(ref Obj_DB_DAL);

                //VERIFICACION DEL MSJ DE ERROR
                if (Obj_DB_DAL.SError == string.Empty)
                {
                    Obj_Empleaos_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Empleaos_DAL.sMsjError = Obj_DB_DAL.SError;
                }

            }
            catch (Exception ex)
            {

                Obj_Empleaos_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void ModificarEmpleados(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            try
            {
                //INSTANCIAR OBJ DE LAS BASES DE DATOS
                cls_DataBase_BLL Obj_DB_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL Obj_DB_DAL = new cls_DataBase_DAL();

                //SOLO LLAMAR EL STORED PROCEDURE A EJECUTAR
                Obj_DB_DAL.SSP_Nombre = "sp_Modificar_Empleados";

                //CREACION DE PARAMETROS PARA LA MODIFICACION DE CADA FILA
                Obj_DB_BLL.Crear_Parametros(ref Obj_DB_DAL);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@IdEmpleado", "2", Obj_Empleados_DAL.cIdEmpleado);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Cedula", "2", Obj_Empleados_DAL.cCedula);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Nombre", "2", Obj_Empleados_DAL.cNombreEmpleado);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Apellidos", "2", Obj_Empleados_DAL.cApellidoEmpleado);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Direccion", "2", Obj_Empleados_DAL.cDireccion);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Edad", "1", Obj_Empleados_DAL.cEdad);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Tel_Casa", "2", Obj_Empleados_DAL.cTelCasa);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Tel_Referencia", "2", Obj_Empleados_DAL.cTelRef);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Celular", "2", Obj_Empleados_DAL.cCelular);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Salario", "6", Obj_Empleados_DAL.dSalario);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@IdTipoEmpleado", "1", Obj_Empleados_DAL.cIdTipoEmpleado);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@IdAerolinea", "1", Obj_Empleados_DAL.cIdAerolinea);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_Empleados_DAL.cIdEstado);

                //EJECUTAR METODO PARA EJCUCION DE MODIFICAR
                Obj_DB_BLL.Execute_NonQuery(ref Obj_DB_DAL);

                //VERIFICACION DEL MSJ DE ERROR
                if (Obj_DB_DAL.SError == string.Empty)
                {
                    Obj_Empleados_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_Empleados_DAL.sMsjError = Obj_DB_DAL.SError;
                }

                Obj_Empleados_DAL.cAccion = 'U';
            }
            catch (Exception ex)
            {

                Obj_Empleados_DAL.sMsjError = ex.Message.ToString();
            }
        }

        public void InsertarEmpleados(ref cls_Empleados_DAL Obj_Empleados_DAL)
        {
            try
            {
                //INSTANCIAR OBJ DE BASE DE DATOS
                cls_DataBase_BLL Obj_DB_BLL = new cls_DataBase_BLL();
                cls_DataBase_DAL Obj_DB_DAL = new cls_DataBase_DAL();

                //LLAMADO DEL STORED PROCEDURE
                Obj_DB_DAL.SSP_Nombre = "sp_Insertar_Empleados";

                //CREACION DE OS PARAMETROS DE LA NUEVA INFO
                Obj_DB_BLL.Crear_Parametros(ref Obj_DB_DAL);
                Obj_DB_BLL.Crear_Parametros(ref Obj_DB_DAL);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@IdEmpleado", "2", Obj_Empleados_DAL.cIdEmpleado);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Cedula", "2", Obj_Empleados_DAL.cCedula);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Nombre", "2", Obj_Empleados_DAL.cNombreEmpleado);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Apellidos", "2", Obj_Empleados_DAL.cApellidoEmpleado);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Direccion", "2", Obj_Empleados_DAL.cDireccion);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Edad", "1", Obj_Empleados_DAL.cEdad);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Tel_Casa", "2", Obj_Empleados_DAL.cTelCasa);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Tel_Referencia", "2", Obj_Empleados_DAL.cTelRef);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Celular", "2", Obj_Empleados_DAL.cCelular);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@Salario", "6", Obj_Empleados_DAL.dSalario);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@IdTipoEmpleado", "1", Obj_Empleados_DAL.cIdTipoEmpleado);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@IdAerolinea", "1", Obj_Empleados_DAL.cIdAerolinea);
                Obj_DB_DAL.dt_Parametros.Rows.Add("@IdEstado", "4", Obj_Empleados_DAL.cIdEstado);

                //EJECUCION DEL METODO PARA INSERTAR
                Obj_DB_BLL.Execute_NonQuery(ref Obj_DB_DAL);

                //VEREFICACION DEL MSJ DE ERROR
                if (Obj_DB_DAL.SError == string.Empty)
                {
                    Obj_Empleados_DAL.sMsjError = string.Empty;
                    Obj_Empleados_DAL.cAccion = 'U';
                }
                else
                {
                    Obj_Empleados_DAL.sMsjError = Obj_DB_DAL.SError;
                    Obj_Empleados_DAL.cAccion = 'I';
                }


            }
            catch (Exception ex)
            {

                Obj_Empleados_DAL.sMsjError = ex.Message.ToString();
            }
        }

    }
}
