﻿using PedroConspira.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroConspira.Application.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        bool NomeProdutoExiste(Produto produto);
    }
}
