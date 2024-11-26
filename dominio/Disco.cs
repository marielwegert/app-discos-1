using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics.Contracts;
//using System.ComponentModel.DataAnnotations; VER
namespace dominio
{
    public class Disco
    {
        //PROPIEDADES
        public int Id { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Fecha de Lanzamiento")]
        //[Date("dd/MM/yyyy")] VER
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Cantidad de Canciones")]
        public int CantidadCanciones { get; set; }
        [DisplayName("Imagen de la Tapa")]
        public string UrlImagenTapa { get; set; }

        public Estilo Estilo { get; set; }
        [DisplayName("Tipo de Edición")]
        public TipoEdicion TipoEdicion { get; set; }

        //CONSTRUCTOR
        //public Disco(Estilo estilo, TipoEdicion tipoEdicion)
        //{
        //    Estilo = estilo;
        //    TipoEdicion = tipoEdicion;
        //}

    }
}
