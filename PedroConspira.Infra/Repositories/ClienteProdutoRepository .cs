﻿using PedroConspira.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroConspira.Infra.Repository
{
    public class ClienteProdutoRepository : RepositoryBase<Domain.Entities.ClienteProduto>, IClienteProdutoRepository
    {
    }
}
