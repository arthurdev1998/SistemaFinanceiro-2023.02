﻿using Domain.Interfaces.IDespesa;
using Entities.Entidades;
using Infra.Repositorio.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositorio
{
    public class RepositorioDespesa : RepositoryGeneric<Despesa>, InterfaceDespesa
    {
        public Task<IList<Despesa>> ListarDespesasUsuario()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Despesa>> ListarDespesasUsuarioNaoPagasMesesAnterior(string emailUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
