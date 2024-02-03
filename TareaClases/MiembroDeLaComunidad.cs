using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClases
{
    public abstract class MiembroDeLaComunidad
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Direccion { get; set; }

        public abstract void Presentarse();
        public virtual void PagarCuota() { }
    }


    
}
