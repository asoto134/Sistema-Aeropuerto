using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Cliente_DAL
    {
        public DataTable Obj_DataTable = new DataTable();

        private char _cIdCliente, _cAccion, _cIdEstado, _cIdTipoCliente;
        private string _sMsjError, _sCedula, _sNombreCliente, _sApellidoCliente, _sTel;

        public char cAccion
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

        public char cIdCliente
        {
            get
            {
                return _cIdCliente;
            }

            set
            {
                _cIdCliente = value;
            }
        }

        public char cIdEstado
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

        public char cIdTipoCliente
        {
            get
            {
                return _cIdTipoCliente;
            }

            set
            {
                _cIdTipoCliente = value;
            }
        }

        public string sApellidoCliente
        {
            get
            {
                return _sApellidoCliente;
            }

            set
            {
                _sApellidoCliente = value;
            }
        }

        public string sCedula
        {
            get
            {
                return _sCedula;
            }

            set
            {
                _sCedula = value;
            }
        }

        public string sMsjError
        {
            get
            {
                return _sMsjError;
            }

            set
            {
                _sMsjError = value;
            }
        }

        public string sNombreCliente
        {
            get
            {
                return _sNombreCliente;
            }

            set
            {
                _sNombreCliente = value;
            }
        }

        public string sTel
        {
            get
            {
                return _sTel;
            }

            set
            {
                _sTel = value;
            }
        }
    }
}
