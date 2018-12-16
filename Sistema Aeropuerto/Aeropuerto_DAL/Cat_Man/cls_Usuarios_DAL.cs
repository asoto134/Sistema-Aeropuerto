using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Usuarios_DAL
    {
        public DataTable OBJ_DataTable = new DataTable();

        private char _cIDEstado, _cAccion;
        private string _sError, _sUsername, _sPassword, _sIdEmpleado ;

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

        public char cIDEstado
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

        public string sError
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

        public string sIdEmpleado
        {
            get
            {
                return _sIdEmpleado;
            }

            set
            {
                _sIdEmpleado = value;
            }
        }

        public string sPassword
        {
            get
            {
                return _sPassword;
            }

            set
            {
                _sPassword = value;
            }
        }

        public string sUsername
        {
            get
            {
                return _sUsername;
            }

            set
            {
                _sUsername = value;
            }
        }
    }
}
