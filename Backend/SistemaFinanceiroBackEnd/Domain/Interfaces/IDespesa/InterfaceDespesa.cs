using Domain.Interfaces.Generics;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IDespesa
{
    // Buscas Personalizadas
    public interface InterfaceDespesa :InterfaceGneric<Despesa>
    {
        Task<IList<Despesa>> ListarDespesasUsuario();
        Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario);
    }
}
