using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Destinos_DAL
    {
        public DataTable Obj_DataTable = new DataTable();

        private Int32 _cIdAerolinea;
        private char _cIdEstado, _cPaisSalida, _cPaisEntrada, _cIdDestino, _cAccion;
        private string _sMsjError, _sNombreDestino;

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

        public int cIdAerolinea
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

        public char cIdDestino
        {
            get
            {
                return _cIdDestino;
            }

            set
            {
                _cIdDestino = value;
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

        public char cPaisEntrada
        {
            get
            {
                return _cPaisEntrada;
            }

            set
            {
                _cPaisEntrada = value;
            }
        }

        public char cPaisSalida
        {
            get
            {
                return _cPaisSalida;
            }

            set
            {
                _cPaisSalida = value;
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

        public string sNombreDestino
        {
            get
            {
                return _sNombreDestino;
            }

            set
            {
                _sNombreDestino = value;
            }
        }
    }
}
