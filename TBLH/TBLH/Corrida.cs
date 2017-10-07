using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBLH
{
    public enum TipoCorrida
    {
        Asfalto = 1, Terra, Grama, Areia
    }
    public class Corrida
    {
        public DateTime Data { get; set; }
        public string Tempo { get; set; }
        public TipoCorrida Tipo { get; set; }
    }
}
