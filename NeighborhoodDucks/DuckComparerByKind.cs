using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace NeighborhoodDucks
{
    class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare([AllowNull] Duck x, [AllowNull] Duck y)
        {
            if (x.Kind < y.Kind)
            {
                return -1;
            }
            if (x.Kind > y.Kind)
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
