using LogisticAppData.DTOs;
using LogisticAppData.Interfaces;
using LogisticAppShared.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticAppShared.Servicios
{
    public class ProductoServicio : IProductoServicio
    {
        private readonly ApplicationDbContext _context;

        public ProductoServicio(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<ProductoDTO> ActualizarProducto(int id, CrearProductoDTO productoDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductoDTO>> BuscarProductos(string categoria)
        {
            throw new NotImplementedException();
        }

        public Task<ProductoDTO> CrearProducto(CrearProductoDTO productoDto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> EliminarProducto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductoDTO?> ObtenerProductoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductoDTO>> ObtenerTodosLosProductos()
        {
            throw new NotImplementedException();
        }
    }
}
