using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Aerolineas_DAL
    {
         public DataTable OBJ_DataTable = new DataTable();

        private char _cIDAerolinea, _cAccion, _cIdEstado;
        private string _sError, _sNombreAerolinea;

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

        public char CIDAerolinea
        {
            get
            {
                return _cIDAerolinea;
            }

            set
            {
                _cIDAerolinea = value;
            }
        }

        public string SNombreAerolinea
        {
            get
            {
                return _sNombreAerolinea;
            }

            set
            {
                _sNombreAerolinea = value;
            }
        }

        public string SError
        {
            get
            {
                return SError1;
            }

            set
            {
                SError1 = value;
            }
        }

        public string SError1
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
    }
}

