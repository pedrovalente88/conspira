﻿using PedroConspira.Domain.Interfaces.Repositories;
using PedroConspira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroConspira.Infra.Repository
{
    public class ProdutoRepository : RepositoryBase<Domain.Entities.Produto>, IProdutoRepository
    {       
        
    }
}
