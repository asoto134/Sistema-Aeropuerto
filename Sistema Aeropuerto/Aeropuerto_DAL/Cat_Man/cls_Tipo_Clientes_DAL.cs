using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Tipo_Clientes_DAL
    {
        
        public DataTable OBJ_DataTable = new DataTable();

        private int _iIdTipoCliente;
        private char _cAccion, _cIdEstado;
        private string _sError, _sTipoCliente, _sDescripcion;

        public int IIdTipoCliente
        {
            get
            {
                return _iIdTipoCliente;
            }

            set
            {
                _iIdTipoCliente = value;
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

        public string STipoCliente
        {
            get
            {
                return _sTipoCliente;
            }

            set
            {
                _sTipoCliente = value;
            }
        }

        public string SDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
            }
        }
    }
}
