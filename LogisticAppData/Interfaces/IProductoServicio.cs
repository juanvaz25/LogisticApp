using LogisticAppData.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticAppData.Interfaces
{
    public interface IProductoServicio
    {
        Task<IEnumerable<ProductoDTO>> ObtenerTodosLosProductos();
        Task<ProductoDTO?> ObtenerProductoPorId(int id);
        Task<ProductoDTO> CrearProducto(CrearProductoDTO productoDto);
        Task<ProductoDTO> ActualizarProducto(int id, CrearProductoDTO productoDto);
        Task<bool> EliminarProducto(int id);
        Task<IEnumerable<ProductoDTO>> BuscarProductos(string categoria);
    }
}
