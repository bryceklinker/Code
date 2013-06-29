using System.Collections.Generic;
using Code.Domain.Entities.Models;

namespace Code.Domain.Gateways.Contexts
{
    public interface Context
    {
        IEnumerable<PlayerModel> Players { get; }
    }
}