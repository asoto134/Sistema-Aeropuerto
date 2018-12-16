using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_tipos_aviones_DAL
    {
        public DataTable OBJ_DataTable = new DataTable();

        private int _iCapacidadPasajeros;
        private char _cAccion, _cIdEstado;
        private string _sError, _sIdTipoAvion, _sNombreAvion, _sDescTipoAvion;
        private decimal _dCapacidad_peso;

        public int ICapacidadPasajeros
        {
            get
            {
                return _iCapacidadPasajeros;
            }

            set
            {
                _iCapacidadPasajeros = value;
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

        public string SNombreAvion
        {
            get
            {
                return _sNombreAvion;
            }

            set
            {
                _sNombreAvion = value;
            }
        }

        public string SDescTipoAvion
        {
            get
            {
                return _sDescTipoAvion;
            }

            set
            {
                _sDescTipoAvion = value;
            }
        }

        public decimal DCapacidad_peso
        {
            get
            {
                return _dCapacidad_peso;
            }

            set
            {
                _dCapacidad_peso = value;
            }
        }
    }
}