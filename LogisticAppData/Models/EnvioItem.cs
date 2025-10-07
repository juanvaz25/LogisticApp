using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticAppData.Models
{
    public class EnvioItem
    {
        public int Id { get; set; }
        public int EnvioId { get; set; }
        public int ProductoId { get; set; }
        [Range(1, int.MaxValue)]
        public int Cantidad { get; set; }
        public decimal PrecioUnidad { get; set; }

        public virtual Envio Envio { get; set; } = null!;
        public virtual Producto Producto { get; set; } = null!;
    }
}
