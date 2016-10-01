using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSchools
{
    [Flags]
    public enum SchoolType
    {
        Gymnasie = 1,
        Grundskola = 2,
        Sarskola = 4
    }
    [Flags]
    public enum Topic
    {
        Techical = 1,
        Omsorg = 2,
        Fordon = 4
    }
}
