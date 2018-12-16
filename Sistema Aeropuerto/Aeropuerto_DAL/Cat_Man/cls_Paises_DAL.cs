using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Paises_DAL
    {
        public DataTable OBJ_DataTable = new DataTable();

        private int _iIdPais;
        private char _cAccion, _cCodigoISOPais, _cCodigoAreaPais, _cIdEstado;
        private string _sError, _sNombrePais;

        public int IIdPais
        {
            get
            {
                return _iIdPais;
            }

            set
            {
                _iIdPais = value;
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

        public char CCodigoISOPais
        {
            get
            {
                return _cCodigoISOPais;
            }

            set
            {
                _cCodigoISOPais = value;
            }
        }

        public char CCodigoAreaPais
        {
            get
            {
                return _cCodigoAreaPais;
            }

            set
            {
                _cCodigoAreaPais = value;
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

        public string SNombrePais
        {
            get
            {
                return _sNombrePais;
            }

            set
            {
                _sNombrePais = value;
            }
        }
    }
}
