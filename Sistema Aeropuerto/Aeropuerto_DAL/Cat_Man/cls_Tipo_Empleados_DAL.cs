using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Tipo_Empleados_DAL
    {
        public DataTable OBJ_DataTable = new DataTable();

        private int _iIDTipoEmpleado;
        private char _cIDEstado, _cAccion;
        private string _sError, _sDescripcionTipo;

        public int IIDTipoEmpleado
        {
            get
            {
                return _iIDTipoEmpleado;
            }

            set
            {
                _iIDTipoEmpleado = value;
            }
        }

        public char CIDEstado
        {
            get
            {
                return _cIDEstado;
            }

            set
            {
                _cIDEstado = value;
            }
        }

        public char CAccion
        {
            get
            {
                return _cAccion;
            }

            set
            {
                _cAccion = value;
            }
        }

        public string SError
        {
            get
            {
                return _sError;
            }

            set
            {
                _sError = value;
            }
        }

        public string SDescripcionTipo
        {
            get
            {
                return _sDescripcionTipo;
            }

            set
            {
                _sDescripcionTipo = value;
            }
        }
    }
}
