using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
   public  class cls_CategoriasVuelos_DAL
    {
        public DataTable OBJ_DataTable = new DataTable();

        private int _iIdCategoria;

        private char  _cAccion, _cIdEstado;
        private string _sError, _sDescCategoria;

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

        public string SDescCategoria
        {
            get
            {
                return _sDescCategoria;
            }

            set
            {
                _sDescCategoria = value;
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

        public int IIdCategoria
        {
            get
            {
                return _iIdCategoria;
            }

            set
            {
                _iIdCategoria = value;
            }
        }
    }
}
