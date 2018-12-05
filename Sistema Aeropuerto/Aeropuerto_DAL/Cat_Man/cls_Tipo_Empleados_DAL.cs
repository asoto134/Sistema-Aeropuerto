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

        private int _iIdTipoEmpleado;
        private char _cAccion, _cIdEstado;
        private string _sError, _sDescTipo;

        public int IIdTipoEmpleado
        {
            get
            {
                return _iIdTipoEmpleado;
            }

            set
            {
                _iIdTipoEmpleado = value;
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

        public char CIdEstado
        {
            get
            {
                return _cIdEstado;
            }

            set
            {
                _cIdEstado = value;
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

        public string SDescTipo
        {
            get
            {
                return _sDescTipo;
            }

            set
            {
                _sDescTipo = value;
            }
        }
    }
}
