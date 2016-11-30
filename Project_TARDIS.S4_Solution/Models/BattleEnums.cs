using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TARDIS
{
    public enum BattleAction
    {
        None,
        Attack,
        Retreat
    }

    public enum BattleResult
    {
        None,
        TravelerWins,
        NPCWins,
        TravelerRetreats,
        NPCRetreats,
        Draw,
        BothRetreat
    }
}
