﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aeropuerto_DAL.Cat_Man
{
   public  class Cls_CategoriasVuelos_DAL
    {
        public DataTable OBJ_DataTable = new DataTable();

        private char _cIdCategoria, _cAccion, _cIdEstado;
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

        public char CIdCategoria
        {
            get
            {
                return _cIdCategoria;
            }

            set
            {
                _cIdCategoria = value;
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
    }
}