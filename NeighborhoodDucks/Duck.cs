using System;
using System.Diagnostics.CodeAnalysis;

namespace NeighborhoodDucks
{
    class Duck : IComparable<Duck>
    {
        public int Size { get; set; }
        public KindOfDuck Kind { get; set; }

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
            {
                return 1;
            }
            if (this.Size < duckToCompare.Size)
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
