using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaClases;

namespace TareaClases
{
    public class Docente : Empleado
    {
        public string? Especialidad { get; set; }
        public List<string>? MateriasImpartidas { get; set; }

        
        public void CalificarExamenes() { }
        
    }
    public class Administrativo : Empleado
    {
        public string? Area { get; set; }
        public List<string>? Funciones { get; set; }
        
        public void GestionarTramites() { }

    }
}


