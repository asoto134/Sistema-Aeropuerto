using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Estados_DAL
    {
        public DataTable OBJ_DataTable = new DataTable();

        private char _cIDEstado, _cAccion;
        private string _sError, _sDescripcion;

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
    }
}
