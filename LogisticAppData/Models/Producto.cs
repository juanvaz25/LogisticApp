using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticAppData.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Precio { get; set; }

        [Range(0, int.MaxValue)]
        public int Stock { get; set; }
        [StringLength(200)]
        public string Categoria { get; set; }

        [Range(0, double.MaxValue)]
        public double Peso { get; set; }

        public DateTime CreadoEl { get; set; } = DateTime.UtcNow;

        public bool Activo { get; set; } = true;

        public virtual ICollection<EnvioItem> EnvioItems { get; set; } = new List<EnvioItem>();
    }
}
