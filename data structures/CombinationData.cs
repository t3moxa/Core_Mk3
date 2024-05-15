using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Mk3.data_structures
{
    public class CombinationData
    {
        public List<(EStoneType, int)> CombinationType { get; set; } = new List<(EStoneType, int)>();
        public Dictionary<EStoneType, int> AmountOfCombinedStones { get; set; } = new Dictionary<EStoneType, int>();
    }
}
