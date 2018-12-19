using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Vuelos_DAL
    {
        public DataTable OBJ_DataTable = new DataTable();

        private char _cIDEstado, _cAccion;
        private int _iIdAerolinea;
        private string _sError, _sIdVuelo, _sIdDestino, _sIdAvion;
        private DateTime _dtFechaHoraSalida, _dtFechaHoraLlegada;

        public char cIDEstado
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

        public int iIdAerolinea
        {
            get
            {
                return _iIdAerolinea;
            }

            set
            {
                _iIdAerolinea = value;
            }
        }

        public string sError
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

        public string sIdVuelo
        {
            get
            {
                return _sIdVuelo;
            }

            set
            {
                _sIdVuelo = value;
            }
        }

        public string sIdDestino
        {
            get
            {
                return _sIdDestino;
            }

            set
            {
                _sIdDestino = value;
            }
        }

        public string sIdAvion
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

        public DateTime dtFechaHoraSalida
        {
            get
            {
                return _dtFechaHoraSalida;
            }

            set
            {
                _dtFechaHoraSalida = value;
            }
        }

        public DateTime dtFechaHoraLlegada
        {
            get
            {
                return _dtFechaHoraLlegada;
            }

            set
            {
                _dtFechaHoraLlegada = value;
            }
        }
    }
}
