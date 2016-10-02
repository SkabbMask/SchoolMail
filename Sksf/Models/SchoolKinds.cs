using System;

namespace Sksf.Models
{
    [Flags]
    public enum SchoolKinds : byte
    {
        Grundskola = 1,
        Gymnasieskola = 2,

        NotSet = 0
    }
}
