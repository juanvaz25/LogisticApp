using System.ComponentModel.DataAnnotations;

namespace LogisticAppData.Models
{
    public class Envio
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string NumeroSeguimiento { get; set; } = string.Empty;
        [Required]
        public string UserId { get; set; } = string.Empty;
        [Required]
        [StringLength(200)]
        public string DireccionDeEnvio { get; set; } = string.Empty;
        public EstadoEnvio Estado { get; set; } = EstadoEnvio.Pedido;
        public decimal PesoTotal { get; set; }
        public decimal CostoEnvio { get; set; }
        public DateTime CreadoEl { get; set; } = DateTime.UtcNow;
        public DateTime? DiaDeEnvio { get; set; }
        public virtual ICollection<EnvioItem> Items { get; set; } = new List<EnvioItem>();

    }

    public enum EstadoEnvio
    {
        Pedido,
        Enviado,
        EnTransito,
        Entregado,
        Cancelado
    }
}