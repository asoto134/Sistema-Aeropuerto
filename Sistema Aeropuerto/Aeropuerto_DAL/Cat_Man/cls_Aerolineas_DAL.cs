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

        private int _cIdAerolinea;

        private char _cAccion, _cIdEstado;
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
                return _sError;
            }

            set
            {
                _sError = value;
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

        public int CIdAerolinea
        {
            get
            {
                return _cIdAerolinea;
            }

            set
            {
                _cIdAerolinea = value;
            }
        }
    }
}

