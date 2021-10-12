using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace NeighborhoodDucks
{
    class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare([AllowNull] Duck x, [AllowNull] Duck y)
        {
            if (x.Size < y.Size)
            {
                return -1;
            }
            if (x.Size > y.Size)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
