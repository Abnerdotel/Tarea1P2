using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClases
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string? Puesto { get; set; }
        public decimal Sueldo { get; set; }
        public string? Area { get; set; }

        public static void CalcularNomina() { }

        public override void Presentarse() { }

       
        
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public string? Carrera { get; set; }
        public string? Matricula { get; set; }
        public double Indice { get; set; }

        public void SolicitarBeca() { }
        public override void Presentarse() { }
    }

    public class Exalumno : MiembroDeLaComunidad
    {
        public string? FechaGraduacion { get; set; }
        public string? TituloObtenido { get; set; }

        public override void Presentarse() { }

        public static void RecordarALaUniversidad() { }

    }

}