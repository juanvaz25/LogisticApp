using LogisticAppData.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticAppData.Interfaces
{
    public interface IEnvioServicio
    {
        Task<IEnumerable<EnvioDTO>> ObtenerTodosLosEnvios();
        Task<IEnumerable<EnvioDTO?>> ObtenerUsuarioEnvio(int userId);
        Task<EnvioDTO?> ObtenerEnvioPorId(int id);
        Task<EnvioDTO?> ObtenerEnvioPorNumeroSeguimiento(string numeroSeguimiento);
        Task<EnvioDTO> CrearEnvio(CrearEnvioDTO envioDto, string userId);
        Task<EnvioDTO?> ActualizarEstadoEnvio(int id, string Estado);
        Task<bool> EliminarEnvio(int id);

    }
}
