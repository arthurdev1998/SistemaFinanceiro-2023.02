using Domain.Interfaces.Generics;
using Domain.Interfaces.ICategoria;
using Entities.Entidades;
using Infra.Configuracao;
using Infra.Repositorio.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioCategoria : RepositoryGeneric<Categoria>, InterfaceCategoria
    {
        public Task<IList<Categoria>> ListarCategoriaUsuario(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
