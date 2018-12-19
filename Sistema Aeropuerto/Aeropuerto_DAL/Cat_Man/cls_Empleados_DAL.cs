using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
    public class cls_Empleados_DAL
    {
        public DataTable Obj_DataTable = new DataTable();

        private char _cAccion;
        private string _cIdEmpleado, _cCedula, _cNombreEmpleado, _cApellidoEmpleado,
            _cEdad, __cTelCasa, _cTelRef, _cCelular, _cIdTipoEmpleado, _cIdAerolinea,
            _cIdEstado, _cDireccion;
        private decimal _dSalario;
        private string _sMsjError;

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

        public string cApellidoEmpleado
        {
            get
            {
                return _cApellidoEmpleado;
            }

            set
            {
                _cApellidoEmpleado = value;
            }
        }

        public string cCedula
        {
            get
            {
                return _cCedula;
            }

            set
            {
                _cCedula = value;
            }
        }

        public string cCelular
        {
            get
            {
                return _cCelular;
            }

            set
            {
                _cCelular = value;
            }
        }

        public string cDireccion
        {
            get
            {
                return _cDireccion;
            }

            set
            {
                _cDireccion = value;
            }
        }

        public string cEdad
        {
            get
            {
                return _cEdad;
            }

            set
            {
                _cEdad = value;
            }
        }

        public string cIdAerolinea
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

        public string cIdEmpleado
        {
            get
            {
                return _cIdEmpleado;
            }

            set
            {
                _cIdEmpleado = value;
            }
        }

        public string cIdEstado
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

        public string cIdTipoEmpleado
        {
            get
            {
                return _cIdTipoEmpleado;
            }

            set
            {
                _cIdTipoEmpleado = value;
            }
        }

        public string cNombreEmpleado
        {
            get
            {
                return _cNombreEmpleado;
            }

            set
            {
                _cNombreEmpleado = value;
            }
        }

        public string cTelCasa
        {
            get
            {
                return __cTelCasa;
            }

            set
            {
                __cTelCasa = value;
            }
        }

        public string cTelRef
        {
            get
            {
                return _cTelRef;
            }

            set
            {
                _cTelRef = value;
            }
        }

        public decimal dSalario
        {
            get
            {
                return _dSalario;
            }

            set
            {
                _dSalario = value;
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
    }
}
