using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace NeighborhoodDucks
{
    class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;
        public int Compare([AllowNull] Duck x, [AllowNull] Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
            {
                if (x.Size > y.Size)
                {
                    return 1;
                }
                else if (x.Size < y.Size)
                {
                    return -1;
                }
                else
                {
                    if (x.Kind > y.Kind)
                    {
                        return 1;
                    }
                    else if (x.Kind < y.Kind)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                if (x.Kind > y.Kind)
                {
                    return 1;
                }
                else if (x.Kind < y.Kind)
                {
                    return -1;
                }
                else
                {
                    if (x.Size > y.Size)
                    {
                        return 1;
                    }
                    else if (x.Size < y.Size)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

        }
    }
}
