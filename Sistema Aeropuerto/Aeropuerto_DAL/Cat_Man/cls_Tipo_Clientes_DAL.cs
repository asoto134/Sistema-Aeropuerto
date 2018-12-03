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

        private int _iIDTipoCliente;
        private char _cIDEstado, _cAccion;
        private string _sError, _sTipoCliente, _sDescripcion;

        public int IIDTipoCliente
        {
            get
            {
                return _iIDTipoCliente;
            }

            set
            {
                _iIDTipoCliente = value;
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
