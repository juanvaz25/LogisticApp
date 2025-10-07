using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticAppData.DTOs
{
    public class EnvioDTO
    {
        public int Id { get; set; }
        public string NumeroSeguimientO { get; set; } = string.Empty;
        public string DireccionDeSalida { get; set; } = string.Empty;
        public string DireccionDeEnvio { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public decimal PesoTotal { get; set; }
        public decimal CostoEnvio { get; set; }
        public DateTime CreadoEl { get; set; }
        public DateTime? DiaDeEnvio { get; set; }
        public List<EnvioItemDTO> Items { get; set; } = new();
    }

    public class CrearEnvioDTO
    {
        [Required]
        [StringLength(200)]
        public string DireccionDeSalida { get; set; } = string.Empty;
        [Required]
        [StringLength(200)]
        public string DireccionDeEnvio { get; set; } = string.Empty;

        public List<CrearEnvioItemDTO> Items { get; set; } = new();
    }

    public class EnvioItemDTO
    {
        public int Id { get; set; }
        public string ProductoNombre { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }
        public decimal Total => Cantidad * PrecioUnidad;
    }
    public class CrearEnvioItemDTO
    {
        [Required]
        public int ProductoId { get; set; }
        [Range(1, int.MaxValue)]
        public int Cantidad { get; set; }
    }
}
