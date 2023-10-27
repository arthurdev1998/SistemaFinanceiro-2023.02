using Domain.Interfaces.Generics;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IUsuarioSistemaFinanceiro
{
    // Busca Personalizada
    public interface InterfaceUsuarioSistemaFinanceiro : InterfaceGneric<UsuarioSistemaFinanceiro>
    {
        Task<IList<UsuarioSistemaFinanceiro>> ListarUsuariosSistema(int IdSistema);
        Task RemoveUsuarios(List<UsuarioSistemaFinanceiro> usuarios);
        Task<UsuarioSistemaFinanceiro> ObterUsuarioPorEmail(string emailUsuario);
    }
}
