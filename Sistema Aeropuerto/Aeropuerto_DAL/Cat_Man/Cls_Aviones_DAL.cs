using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Aviones_DAL
    {
        public DataTable OBJ_DataTable = new DataTable();

        private char _cAccion, _cIdAerolinea, _cIdEstado;
        private string _sError, _sNombreAerolinea, _sNomAvion, _sIdAvion,
                         _sDescAvion, _sIdTipoAvion;

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

        public char CIdAerolinea
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

        public string SDescAvion
        {
            get
            {
                return _sDescAvion;
            }

            set
            {
                _sDescAvion = value;
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

        public string SIdAvion
        {
            get
            {
                return _sIdAvion;
            }

            set
            {
                _sIdAvion = value;
            }
        }

        public string SIdTipoAvion
        {
            get
            {
                return _sIdTipoAvion;
            }

            set
            {
                _sIdTipoAvion = value;
            }
        }

        public string SNomAvion
        {
            get
            {
                return _sNomAvion;
            }

            set
            {
                _sNomAvion = value;
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
    }
}
