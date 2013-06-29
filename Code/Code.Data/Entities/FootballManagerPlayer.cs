using System.Collections.Generic;
using Code.Domain.Entities;

namespace Code.Data.Entities
{
    public interface FootballManagerPlayer
    {
        string FirstName { get; }
        string LastName { get; }
        int Age { get; }
        int CurrentAbility { get; }
        int PotentialAbility { get; }
        IEnumerable<Position> Positions { get; }
    }
}