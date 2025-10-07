using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticAppData.DTOs
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public double Peso { get; set; }
        public bool Activo { get; set; }
    }

    public class CrearProductoDTO
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = string.Empty;
        [StringLength(500)]
        public string Descripcion { get; set; } = string.Empty;
        [Range(0, double.MaxValue)]
        public decimal Precio { get; set; }
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }
        [StringLength(200)]
        public string Categoria { get; set; } = string.Empty;
        [Range(0, double.MaxValue)]
        public double Peso { get; set; }
    }
}
