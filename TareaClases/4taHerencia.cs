using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaClases;

namespace TareaClases
{
    public class Maestro : Docente
    {
    public string? Materia { get; set; }
    public List<string>? Funciones { get; set; }
    
    public void GestionTramites() { }

    }

public class Administrador : Docente
{
    public string? Cargo { get; set; }
    public List<string>? Responsabilidades { get; set; }

    

    
}

}
