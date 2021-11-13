using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public class Pelicula : ICloneable
    {
        public int CodigoPelicula { get; set; }
        public string Nombre { get; set; }

        public DateTime FechaEstreno { get; set; }

        public Pelicula()
        {

        }

        public Pelicula(int codigoPelicula, string nombre, DateTime fechaEstreno)
        {
            this.CodigoPelicula = codigoPelicula;
            this.Nombre = nombre;
            this.FechaEstreno = fechaEstreno;
        }

        public string MostarPelicula()
        {
            return $"La pelicula con id {this.CodigoPelicula} cuyo nombre es {this.Nombre} y su fecha de estreno {this.FechaEstreno.ToShortDateString()}";
        }

        public object Clone()
        {
            return (Pelicula) this.MemberwiseClone();
        }
    }
}

