﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Model
{
    class TipoVehiculo
    {
       
            public int Codigo { get; set; }
            public string Descripcion { get; set; }
            public int CodigoVehiculo { get; set; }
            public int Estado { get; set; }
        public virtual TipoVehiculo CodigoSocioNavigation { get; set; }



    }
}
