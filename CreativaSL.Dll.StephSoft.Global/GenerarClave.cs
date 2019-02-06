using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativaSL.Dll.StephSoft.Global
{
    public class GenerarClave
    {
        public GenerarClave()
        {
            Resultado = 0;
            ClavesProduccion = string.Empty;
        }

        private int Resultado;

        public int _Resultado
        {
            get { return Resultado; }
            set { Resultado = value; }
        }
        private string ClavesProduccion;

        public string _ClavesProduccion
        {
            get { return ClavesProduccion; }
            set { ClavesProduccion = value; }
        }


    }
}
