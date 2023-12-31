﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Socca.Players.Domain.Entities;

namespace Socca.Players.Domain.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> Get();
        Task Add(Player player);
    }
}
